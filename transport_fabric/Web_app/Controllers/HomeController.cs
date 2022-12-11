using Common;
using MailKit.Net.Pop3;
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
using System.Threading;
using System.Threading.Tasks;
using Web_app.Models;

namespace Web_app.Controllers
{
    public class HomeController : Controller
    {
        ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_client { get; set; }
        [Obsolete]
        List<Departure> departures { get; set; } = new List<Departure>();
        public HomeController()
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


        [HttpPost("/login")]
        public async Task<IActionResult> login(string username, string password)
        {
            
            //Send to table and check
            //FabricClient fabric_client = new FabricClient();

            //int partition_number = (await fabric_client.QueryManager.GetApplicationListAsync(new Uri("fabric:/transport_fabric/transaction_cordinator"))).Count;
            ViewBag.departures = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_all_departures());
            ViewBag.history = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_history_purchases());
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


        [HttpPost("/filter")]
        public async Task<IActionResult> filter(string type, DateTime departure_day,string free_tickets)
        {
           if (free_tickets == null)
                free_tickets = "off";
            ViewBag.departures = await service_partition_client.InvokeWithRetryAsync(
                                    x => x.Channel.return_filtered_departures(type, free_tickets, departure_day));

            ViewBag.history = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_history_purchases());
            return View("user_store");
        }



        [HttpPost("/purchase")]
        public async Task<IActionResult> purchase(string username, int id_departure, int count)
        {
            
            bool flag = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.prepare(username, id_departure, count));

            if(flag)
                Console.WriteLine("Made it");
            else
                Console.WriteLine("Something wrong");
            ViewBag.departures = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_all_departures());


            ViewBag.history = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_history_purchases());
            return View("user_store");
        }

        [HttpPost("/cancel_ticket")]
        public async Task<IActionResult> cancel_ticket(int purchase_id)
        {
            bool flag = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.cancel_purchase(purchase_id));
            if (flag)
                Console.WriteLine("Made it");
            else
                Console.WriteLine("Something wrong");

            ViewBag.departures = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_all_departures());


            ViewBag.history = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_history_purchases());

            return View("user_store");
        }


        [HttpPost("/filter_history")]
        public async Task<IActionResult> filter_history(string departure_day, string free_tickets)
        {


            ViewBag.history = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.filter_history_purchases(departure_day, free_tickets));
            ViewBag.departures = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_all_departures());

            return View("user_store");
        }

        [HttpPost("/add_departure")]
        public async Task<IActionResult> add_departure(type_transport transport, double ticket_price, int total_tickets, DateTime departure_day, double lat, double lon)
        {

            await service_partition_client.InvokeWithRetryAsync(x => x.Channel.add_departure(transport, ticket_price, total_tickets, departure_day, lat, lon));


            ViewBag.history = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_history_purchases());
            ViewBag.departures = await service_partition_client.InvokeWithRetryAsync(x => x.Channel.return_all_departures());

            return View("user_store");
        }
    }
}
