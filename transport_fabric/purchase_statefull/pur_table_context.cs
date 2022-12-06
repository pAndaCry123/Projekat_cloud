using Common;
using depart_statefull;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_statefull;

namespace purchase_statefull
{
    public class pur_table_context
    {
        private CloudStorageAccount _storageAccount;
        private CloudTable _table;
        public pur_table_context()
        {
            _storageAccount =
           CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("ConnectionString"));
            CloudTableClient tableClient = new CloudTableClient(new
           Uri(_storageAccount.TableEndpoint.AbsoluteUri), _storageAccount.Credentials);
            _table = tableClient.GetTableReference("PurchaseTable");
            _table.CreateIfNotExists();
        }

        public string return_count_purchase()
        {
            var results = from g in _table.CreateQuery<Purchase>()
                          where g.PartitionKey == "Purchase"
                          select g;
            try
            {
                return (results.ToList().Count).ToString();
            }
            catch (Exception ex)
            {
                return "0";
            }

        }

        public async Task<Purchase> return_pruchase(int purchase_id)
        {
            var results = from g in _table.CreateQuery<Purchase>()
                          where g.PartitionKey == "Purchase"
                          select g;

            foreach (var item in results.ToList())
            {
                if (item.purchase_id == purchase_id)
                    return item;
            }
            return null;
        }

        public async Task<bool> check_can_purchase_cancel(int purchase_id)
        {
            var results = from g in _table.CreateQuery<Purchase>()
                          where g.PartitionKey == "Purchase"
                          select g;

            Purchase purchase = null;
            foreach (var item in results.ToList())
            {
                if (item.purchase_id == purchase_id)
                {
                    purchase = item;
                    break;
                }
            }

            if (purchase != null)
            {
                Departure departure =  await new dep_table_context().retrun_one_departure_by_id(purchase.departure_id);
                if(departure != null)
                {
                    DateTime date_plus_five = DateTime.Now.AddDays(5);
                    DateTime deparutre_day = DateTime.Parse(departure.day_departure);

                    if (DateTime.Compare(date_plus_five, deparutre_day) < 0)
                        return true;

                }
            }
            return false;

        }
        public async Task delete_purchase(Purchase purchase)
        {
            TableOperation insertOperation = TableOperation.Delete(purchase);
            _table.Execute(insertOperation);
        }

        public async Task add_new_pruchase(Purchase new_pruchase)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_pruchase);
            _table.Execute(insertOperation);
        }
    }
}
