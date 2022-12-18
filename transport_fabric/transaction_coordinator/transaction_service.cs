﻿using Common;
using MailKit.Net.Pop3;
using Microsoft.ServiceFabric.Data;
using Microsoft.ServiceFabric.Data.Collections;
using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Communication.Client;
using Microsoft.ServiceFabric.Services.Communication.Wcf;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Client;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction_coordinator
{
    public class transaction_service : ITransactions
    {
        ServicePartitionClient<WcfCommunicationClient<IUser_service>> service_partition_user;
        ServicePartitionClient<WcfCommunicationClient<IDepratire>> service_departure;
        ServicePartitionClient<WcfCommunicationClient<IPurchase>> service_purchase;
        ServicePartitionClient<WcfCommunicationClient<IBank>> service_account;
        IReliableStateManager manager;
        history_service history;
        int count;
        public transaction_service(IReliableStateManager manager)
        {
            this.manager = manager;
            count = 0;
            var binding = WcfUtility.CreateTcpClientBinding();
            this.service_partition_user = new
                    ServicePartitionClient<WcfCommunicationClient<IUser_service>>(
                        new WcfCommunicationClientFactory<IUser_service>(clientBinding: binding),
                        new Uri("fabric:/transport_fabric/user_statefull"),
                        new ServicePartitionKey(0)); //ovde se menja kasnije


            this.service_departure = new
                    ServicePartitionClient<WcfCommunicationClient<IDepratire>>(
                        new WcfCommunicationClientFactory<IDepratire>(clientBinding: binding),
                        new Uri("fabric:/transport_fabric/depart_statefull"),
                        new ServicePartitionKey(0)); //ovde se menja kasnije

            this.service_purchase = new
                   ServicePartitionClient<WcfCommunicationClient<IPurchase>>(
                       new WcfCommunicationClientFactory<IPurchase>(clientBinding: binding),
                       new Uri("fabric:/transport_fabric/purchase_statefull"),
                       new ServicePartitionKey(0)); //ovde se menja kasnije

            this.service_account = new
                   ServicePartitionClient<WcfCommunicationClient<IBank>>(
                       new WcfCommunicationClientFactory<IBank>(clientBinding: binding),
                       new Uri("fabric:/transport_fabric/bank_statefull"),
                       new ServicePartitionKey(0)); //ovde se menja kasnije
            //this.load_email_tickets();
            history = new history_service();
            //load_history();
         
        }
        private async Task load_dict()
        {

            List<Departure> deps = await service_departure.InvokeWithRetry(x => x.Channel.return_all_departures());

            var departures = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
            using (var tx = this.manager.CreateTransaction())
            {
                List<Departure> users_list = (await departures.TryGetValueAsync(tx, "departures")).Value;
                foreach (var item in deps)
                {
                    users_list.Add(item);
                }
                await departures.TryRemoveAsync(tx, "departures");
                await departures.TryAddAsync(tx, "departures", users_list);
                await tx.CommitAsync();
            }
        }
        private async Task load_dictionaries()
        {
            while (true)
            {
                var users = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<User>>>("users");
                using (var tx = this.manager.CreateTransaction())
                {
                    List<User> users_list = (await users.TryGetValueAsync(tx, "users")).Value;
                    foreach (var item in users_list)
                    {
                        await service_partition_user.InvokeWithRetryAsync(x => x.Channel.create_user_dict(item));
                    }
                    await tx.CommitAsync();
                }
                var departures = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
                using (var tx = this.manager.CreateTransaction())
                {
                    List<Departure> users_list = (await departures.TryGetValueAsync(tx, "departures")).Value;
                    foreach (var item in users_list)
                    {
                        await service_departure.InvokeWithRetryAsync(x => x.Channel.add_departure_dict(item));
                    }
                    await tx.CommitAsync();
                }
                await Task.Delay(60000);
            }
            
        }



        private  async Task load_history()
        {
            while (true)
            {
                List<Departure> deparutres = await service_departure.InvokeWithRetryAsync(x => x.Channel.return_all_departures());
                List<Purchase> purchases = await service_purchase.InvokeWithRetryAsync(x => x.Channel.list_all_purchases());
                List<Purchase> datas = new List<Purchase>();
                foreach (var item in purchases)
                {
                    Departure departure = null;
                    foreach (var deps in deparutres)
                    {
                        if (deps.id == item.departure_id)
                        {
                            departure = deps;
                            break;
                        }
                    }
                    if (departure != null)
                    {
                        DateTime date = DateTime.Parse(departure.day_departure);
                        if (DateTime.Compare(date, DateTime.Now.Date) < 0)
                        {
                            datas.Add(item);
                        }
                    }
                }


                await history.load_to_table(datas);
                await Task.Delay(70000);
            }
            
        }
        private async Task load_email_tickets()
        {
            while (true)
            {
                try
                {
                    using (var client = new Pop3Client())
                    {
                        client.Connect("pop.gmail.com", 995, true);
                        client.Authenticate("ccloud237@gmail.com", "qzpvluucjvsdydqo");

                        for (int i = 0; i < client.Count; i++)
                        {
                            var message = await client.GetMessageAsync(i);
                            string[] data = message.TextBody.Split(',');

                            bool flag = await this.prepare(data[0]
                                                , int.Parse(data[1]), int.Parse(data[2]));

                            if (flag)
                                Console.WriteLine("It is ok ");

                        }

                        client.Disconnect(true);
                    }
                     
                
                }catch(Exception ex){ }
                await Task.Delay(80000);
            }
        }
        public async Task<bool> cancel_purchase(int purchase_id)
        {
            bool flag = await service_purchase.InvokeWithRetryAsync(x => x.Channel.cancel_purchase(purchase_id));

            if (flag)
            {
                Purchase purchase = await service_purchase.InvokeWithRetryAsync(x => x.Channel.purchase_get(purchase_id));

                User user = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.return_user(purchase.username));
                Departure departure = await service_departure.InvokeWithRetryAsync(x => x.Channel.return_departure(purchase.departure_id, 0));

                if(user != null && departure != null)
                {
                    Account account = await service_account.InvokeWithRetryAsync(x => x.Channel.account_get(user.account_id));

                    await service_account.InvokeWithRetryAsync(x => x.Channel.update_account(account.account_id, departure.ticket_price * purchase.count_tickets));
                    await service_departure.InvokeWithRetryAsync(x => x.Channel.retrive_deprature(departure.id, purchase.count_tickets));

                    await this.commit_purchase(purchase);

                    var departures = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
                    using (var tx = this.manager.CreateTransaction())
                    {
                        List<Departure> users_list = (await departures.TryGetValueAsync(tx, "departures")).Value;
                        foreach (var item in users_list)
                        {
                            if(item.id == departure.id)
                            {
                                item.free_ticket_slots += purchase.count_tickets;
                                break;
                            }
                        }
                        await departures.TryRemoveAsync(tx, "departures");
                        await departures.TryAddAsync(tx, "departures",users_list);
                        await tx.CommitAsync();
                    }

                    return true;
                }

            }
            return false;
        }

        public async Task<bool> check_user(string username, string password)
        {
            FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/user_statefull"))).Count;
            var binding = WcfUtility.CreateTcpClientBinding();
            int index = 0;
            bool flag = false;
            //for (int i = 0; i < partition_number; i++)
            //{
                //this.service_partition_user = new
                //    ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                //        new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                //        new Uri("fabric:/transport_fabric/user_statefull"),
                //        new ServicePartitionKey(0)); //ovde se menja kasnije

                flag = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.check_user(username, password));
                index++;
            //}

            //for (int i = 0; i < partition_number; i++)
            //{

            this.load_email_tickets();
            load_history();
            load_dictionaries();
            await load_dict();
            return flag;
        }

        public async Task commit(Departure deparutre, User user,int count)
        {
            try
            {
                int number = await service_purchase.InvokeWithRetryAsync(x => x.Channel.create_pruchase(deparutre.id, count,user.username));

                await service_partition_user.InvokeWithRetryAsync(x => x.Channel.update_user_purchase_list(number, user.username));
                await service_account.InvokeWithRetryAsync(x => x.Channel.update_user_account(user.account_id, deparutre.ticket_price * count));
                await service_departure.InvokeWithRetryAsync(x => x.Channel.update_deprature(deparutre.id, count));

                var departures = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
                using (var tx = this.manager.CreateTransaction())
                {
                    List<Departure> users_list = (await departures.TryGetValueAsync(tx, "departures")).Value;
                    foreach (var item in users_list)
                    {
                        if(item.id == deparutre.id)
                        {
                            item.free_ticket_slots -= count;
                        }
                    }
                    await tx.CommitAsync();
                }
            }
            catch (Exception ex)
            {
                await this.rollback();
            }
        }

        public async Task commit_purchase(Purchase purchase)
        {
            try
            {
                await service_purchase.InvokeWithRetryAsync(x => x.Channel.delete_purchase(purchase));
            }catch(Exception ex)
            {
                await this.rollback();
            }
        }

        public async Task<bool> create_user(string username, string email, string password, int account_id)
        {
            FabricClient fabric_client = new FabricClient();

            int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/user_statefull"))).Count;
            var binding = WcfUtility.CreateTcpClientBinding();
            int index = 0;
            bool flag = false;
            //for (int i = 0; i < partition_number; i++)
            //{
              
            flag = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.create_user(username,email, password,account_id));
            if (flag)
            {
                var users = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<User>>>("users");
                using (var tx = this.manager.CreateTransaction())
                {
                    List<User> users_list = (await users.TryGetValueAsync(tx, "users")).Value;
                    User user = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.return_user(username));
                    users_list.Add(user);
                    await users.TryRemoveAsync(tx, "users");
                    await users.TryAddAsync(tx, "users",users_list);
                    await tx.CommitAsync();
                }
            }
                index++;
            //}

            return flag;
        }

    

        public async Task<bool> prepare(string username, int id_departure, int count)
        {
            Departure departure = await service_departure.InvokeWithRetryAsync(x => x.Channel.return_departure(id_departure, count));
            User user = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.return_user(username));


            if (departure != null && user != null)
            {
                double number = await service_account.InvokeWithRetryAsync(x => x.Channel.get_resources(user.account_id)) - (departure.ticket_price * count);
                if (number > 0)
                {
                    this.count = count;
                    await this.commit(departure, user,count);
                    return true;
                }
                return false;
            }
            else
                return false;

        }

        public async Task<List<Departure>> return_all_departures()
        {
            return await service_departure.InvokeWithRetryAsync(x => x.Channel.return_all_departures());
        }

        public async Task<List<Departure>> return_filtered_departures(string type, string tickets, DateTime date)
        {
            return await service_departure.InvokeWithRetryAsync(x => x.Channel.return_filtered_departures(type, tickets, date));
        }

        public async Task rollback()
        {
            Console.WriteLine("Server is rollbacked");
        }

        public async Task<List<Purchase>> return_history_purchases()
        {
            return await history.return_all_purchases();
        }

        public async Task<List<Purchase>> filter_history_purchases(string date, string tickets)
        {
            List<Purchase> history_list = await history.return_all_purchases();
            List<Purchase> ret = new List<Purchase>();

            List<Departure> dep_list = await service_departure.InvokeWithRetryAsync(x => x.Channel.return_all_departures());

            if(date != null && date!= "off")
                dep_list.Sort((a, b) =>  DateTime.Compare(DateTime.Parse(b.day_departure), DateTime.Parse(a.day_departure)));
            if(tickets!=null &&  tickets!= "off" )
                dep_list.Sort((a, b) => a.free_ticket_slots.CompareTo(b.free_ticket_slots));

            foreach (var item in dep_list)
            {
                foreach (var item1 in history_list)
                {
                    if(item.id == item1.departure_id)
                    {
                        ret.Add(item1);
                    }
                }

            }

            return ret;
        }

        public async Task add_departure(type_transport transport, double ticket_price, int total_tickets, DateTime departure_day, double lat, double lon)
        {
            await service_departure.InvokeWithRetryAsync(x => x.Channel.add_departure(transport, ticket_price, total_tickets, departure_day, lat, lon));
            List<Departure> departures = await service_departure.InvokeWithRetryAsync(x => x.Channel.return_all_departures());
            foreach (var item in departures)
            {
                if(item.ticket_price == ticket_price && item.type == transport.ToString())
                {
                    var departure = await this.manager.GetOrAddAsync<IReliableDictionary<string, List<Departure>>>("departures");
                    using (var tx = this.manager.CreateTransaction())
                    {
                        List<Departure> users_list = (await departure.TryGetValueAsync(tx, "departures")).Value;
                        users_list.Add(item);
                        await departure.TryRemoveAsync(tx, "departures");
                        bool flag = await departure.TryAddAsync(tx, "departures", users_list);
                        await tx.CommitAsync();
                    }
                }

            }
        }
    }
}
