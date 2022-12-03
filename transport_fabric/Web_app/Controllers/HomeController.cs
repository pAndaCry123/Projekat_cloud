using Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Communication.Client;
using Microsoft.ServiceFabric.Services.Communication.Wcf;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Fabric;
using System.Linq;
using System.Threading.Tasks;
using Web_app.Models;

namespace Web_app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["login"] = "true";
            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> login(string username, string password)
        {
            //Send to table and check
            FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/transaction_cordinator"))).Count;
            var binding = WcfUtility.CreateTcpClientBinding();

          

            ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_client = new
                ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                    new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                    new Uri("fabric:/transport_fabric/transaction_coordinator"),
                    new ServicePartitionKey(0)); //ovde se menja kasnije
            bool flag = await service_partition_client.InvokeWithRetryAsync(client => client.Channel.check_user(username, password));
            if (flag)
                return View("user_store");
            return View("Index");
        }
        [HttpPost("/register")]
        public async Task<IActionResult> register(string username,string email,int account_id, string password)
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
                return View("Index");
            return View("Index");
        }
        [HttpGet("/register_get")]
        public IActionResult register_get()
        {
            //Send to table and check
            return View("register");
        }

        [HttpGet("/login_get")]
        public IActionResult login_get()
        {
            //Send to table and check
            return View("index");
        }

    }
}
