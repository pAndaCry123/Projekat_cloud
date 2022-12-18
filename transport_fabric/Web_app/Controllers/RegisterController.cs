using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Communication.Client;
using Microsoft.ServiceFabric.Services.Communication.Wcf;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Client;
using System;
using System.Collections.Generic;
using System.Fabric;
using System.Threading.Tasks;

namespace Web_app.Controllers
{
    public class RegisterController : Controller
    {
        ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_client { get; set; }
        public RegisterController()
        {
            load();
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public void load()
        {
            var binding = WcfUtility.CreateTcpClientBinding();

            service_partition_client = new
                ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                    new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                    new Uri("fabric:/transport_fabric/transaction_coordinator"),
                    new ServicePartitionKey(0)); //ovde se menja kasnije


        }


        [HttpPost("/register")]
        public async Task<IActionResult> register(string username, string email, int account_id, string password)
        {
            FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/Zadatak2/transaction_cordinator"))).Count;
            var binding = WcfUtility.CreateTcpClientBinding();

            ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_client = new
                ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                    new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                    new Uri("fabric:/transport_fabric/transaction_coordinator"),
                    new ServicePartitionKey(0)); //ovde se menja kasnije
            bool flag = await service_partition_client.InvokeWithRetryAsync(client => client.Channel.create_user(username, email, password, account_id));
            if (flag)
                return RedirectToAction("Index","Login");
            return View("Index");
        }
    }
}
