using Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task add_new_pruchase(Purchase new_pruchase)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_pruchase);
            _table.Execute(insertOperation);
        }
    }
}
