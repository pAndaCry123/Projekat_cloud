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
        ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_client;
        List<Departure> departures;

        public HomeController()
        {
            load();
            import();
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async void load()
        {
            var binding = WcfUtility.CreateTcpClientBinding();

            service_partition_client = new
                ServicePartitionClient<WcfCommunicationClient<ITransactions>>(
                    new WcfCommunicationClientFactory<ITransactions>(clientBinding: binding),
                    new Uri("fabric:/transport_fabric/transaction_coordinator"),
                    new ServicePartitionKey(0)); //ovde se menja kasnije

            
        }
        public async void import()
        {
            departures = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_all_departures());
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
            //FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/transaction_cordinator"))).Count;
            import();
            bool flag = await service_partition_client.InvokeWithRetryAsync(client => client.Channel.check_user(username, password));
            if (flag)
                return View("user_store",departures);
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


        [HttpPost("/filter")]
        public async Task<IActionResult> filter(string type, DateTime departure_day,string free_tickets)
        {
            //Send to table and check
            //FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/transaction_cordinator"))).Count;

            //bool flag = await service_partition_client.InvokeWithRetryAsync(client => client.Channel.check_user(username, password));
            if (free_tickets == null)
                free_tickets = "off";
            departures = await service_partition_client.InvokeWithRetryAsync(
                                    x => x.Channel.return_filtered_departures(type, free_tickets, departure_day));
                return View("user_store", departures);
        }



        [HttpPost("/purchase")]
        public async Task<IActionResult> purchase(string username, int id_departure, int count)
        {
            //Send to table and check
            //FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/transaction_cordinator"))).Count;

            //bool flag = await service_partition_client.InvokeWithRetryAsync(client => client.Channel.check_user(username, password));
            bool flag = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.prepare(username, id_departure, count));

            if(flag)
                Console.WriteLine("Made it");
            else
                Console.WriteLine("Something wrong");
            return View("user_store",departures);
        }

    }
}
