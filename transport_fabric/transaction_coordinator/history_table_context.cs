using Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction_coordinator
{
    public class history_table_context
    {
        private CloudStorageAccount _storageAccount;
        private CloudTable _table;
        public history_table_context()
        {
            _storageAccount =
           CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("ConnectionString"));
            CloudTableClient tableClient = new CloudTableClient(new
           Uri(_storageAccount.TableEndpoint.AbsoluteUri), _storageAccount.Credentials);
            _table = tableClient.GetTableReference("HistoryTable");
            _table.CreateIfNotExists();
        }

        public async Task<List<Purchase>> return_all_purchase()
        {
            var results = from g in _table.CreateQuery<Purchase>()
                          where g.PartitionKey == "Purchase"
                          select g;
            return results.ToList();

        }
        public async Task add_to_history_table(List<Purchase> list)
        {
            foreach (var item in list)
            {
                await add_new_pruchase(item);
            }

        }


        public async Task add_new_pruchase(Purchase new_pruchase)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_pruchase);
            _table.Execute(insertOperation);
        }
    }
}
