using Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depart_statefull
{
    public class dep_table_context
    {
        private CloudStorageAccount _storageAccount;
        private CloudTable _table;
        public dep_table_context()
        {
            _storageAccount =
           CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("ConnectionString"));
            CloudTableClient tableClient = new CloudTableClient(new
           Uri(_storageAccount.TableEndpoint.AbsoluteUri), _storageAccount.Credentials);
            _table = tableClient.GetTableReference("DepTable");
            _table.CreateIfNotExists();
        }
       
        public void add_user(Departure new_user)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_user);
            _table.Execute(insertOperation);
        }
    }
}
