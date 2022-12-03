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
        ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_user;
        ServicePartitionClient<WcfCommunicationClient<IDepratire>> service_departure;
        ServicePartitionClient<WcfCommunicationClient<IPurchase>> service_purchase;
        public async Task<bool> check_user(string username, string password)
        {
            FabricClient fabric_client = new FabricClient();

            int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/user_statefull"))).Count;
            var binding = WcfUtility.CreateTcpClientBinding();
            int index = 0;
            bool flag = false;
            //for (int i = 0; i < partition_number; i++)
            //{
                this.service_partition_user = new
                    ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                        new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                        new Uri("fabric:/transport_fabric/user_statefull"),
                        new ServicePartitionKey(0)); //ovde se menja kasnije

                flag = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.check_user(username, password));
                index++;
            //}
         
            //for (int i = 0; i < partition_number; i++)
            //{
            this.service_departure = new
                ServicePartitionClient<WcfCommunicationClient<IDepratire>>(
                    new WcfCommunicationClientFactory<IDepratire>(clientBinding: binding),
                    new Uri("fabric:/transport_fabric/depart_statefull"),
                    new ServicePartitionKey(0)); //ovde se menja kasnije

            await service_departure.InvokeWithRetryAsync(x => x.Channel.hit());


            this.service_purchase = new
               ServicePartitionClient<WcfCommunicationClient<IPurchase>>(
                   new WcfCommunicationClientFactory<IPurchase>(clientBinding: binding),
                   new Uri("fabric:/transport_fabric/purchase_statefull"),
                   new ServicePartitionKey(0)); //ovde se menja kasnije

            await service_departure.InvokeWithRetryAsync(x => x.Channel.hit());
            index++;


            return flag;
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
                this.service_partition_user = new
                    ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                        new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                        new Uri("fabric:/transport_fabric/user_statefull"),
                        new ServicePartitionKey(0)); //ovde se menja kasnije

                flag = await service_partition_user.InvokeWithRetryAsync(x => x.Channel.create_user(username,email, password,account_id));
                index++;
            //}

            return flag;
        }
    }
}
