using Common;
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
        int count;
        public transaction_service()
        {
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
          


            return flag;
        }

        public async Task commit(Departure deparutre, User user)
        {
            try
            {
                int number = await service_purchase.InvokeWithRetryAsync(x => x.Channel.create_pruchase(deparutre.id, count,user.username));

                await service_partition_user.InvokeWithRetryAsync(x => x.Channel.update_user_purchase_list(number, user.username));
                await service_account.InvokeWithRetryAsync(x => x.Channel.update_user_account(user.account_id, deparutre.ticket_price * count));
                await service_departure.InvokeWithRetryAsync(x => x.Channel.update_deprature(deparutre.id, count));
            }
            catch (Exception ex)
            {
                this.rollback();
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
                    await this.commit(departure, user);
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
    }
}
