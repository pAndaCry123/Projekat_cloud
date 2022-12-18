using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Client;
using Microsoft.ServiceFabric.Services.Communication.Client;
using Microsoft.ServiceFabric.Services.Communication.Wcf;
using Microsoft.ServiceFabric.Services.Communication.Wcf.Client;
using System;
using System.Threading.Tasks;

namespace Web_app.Controllers
{
    public class LoginController : Controller
    {

        ServicePartitionClient<WcfCommunicationClient<ITransactions>> service_partition_client { get; set; }
        public LoginController()
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
            {
                HttpContext.Session.SetString("user", username);
                return RedirectToAction("Index", "User");
            }
                
            return View("Index");
        }
    }
}
