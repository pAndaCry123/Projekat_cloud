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
       
        public void add_new_pruchase(Purchase new_pruchase)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_pruchase);
            _table.Execute(insertOperation);
        }
    }
}
