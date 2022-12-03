using Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_statefull
{
    public class user_table_context
    {
        private CloudStorageAccount _storageAccount;
        private CloudTable _table;
        public user_table_context()
        {
            _storageAccount =
           CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("ConnectionString"));
            CloudTableClient tableClient = new CloudTableClient(new
           Uri(_storageAccount.TableEndpoint.AbsoluteUri), _storageAccount.Credentials);
            _table = tableClient.GetTableReference("UserTable");
            _table.CreateIfNotExists();
        }
        public string return_count_users ()
        {
            var results = from g in _table.CreateQuery<User>()
                          where g.PartitionKey == "User"
                          select g;
            try
            {
                return results.Count().ToString();
            }catch(Exception ex)
            {
                return "0";
            }
           
        }

        public async Task<User> return_user(string username, string password)
        {
            var results = from g in _table.CreateQuery<User>()
                          where g.PartitionKey == "User"
                          select g;

            foreach (User item in results)
            {
                if (item.username.Equals(username) && item.password.Equals(password))
                {
                    return item;
                }
            }
            return null;
        }
        public async Task<bool> check_user(string username, string password)
        {
            var results = from g in _table.CreateQuery<User>()
                          where g.PartitionKey == "User"
                          select g;

            foreach (User item in results)
            {
                if (item.username.Equals(username) && item.password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }
        public void add_user(User new_user)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_user);
            _table.Execute(insertOperation);
        }
    }
}
