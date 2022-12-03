using Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_statefull
{
    public class bank_table_context
    {
        private CloudStorageAccount _storageAccount;
        private CloudTable _table;
        public bank_table_context()
        {
            _storageAccount =
           CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("ConnectionString"));
            CloudTableClient tableClient = new CloudTableClient(new
           Uri(_storageAccount.TableEndpoint.AbsoluteUri), _storageAccount.Credentials);
            _table = tableClient.GetTableReference("AccountTable");
            _table.CreateIfNotExists();
        }


        public async Task<double> return_resources(int account_id)
        {
            var results = from g in _table.CreateQuery<Account>()
                          where g.PartitionKey == "Account"
                          select g;

            foreach (Account item in results)
            {
                if (item.account_id == account_id)
                {
                    return item.amount;
                }
            }
            return -1;
        }

        public void add_account(Account new_acc)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_acc);
            _table.Execute(insertOperation);
        }
    }
}
