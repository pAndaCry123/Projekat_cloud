using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class User : TableEntity
    {
        public string username { get; set; }
        public string email { get; set; }
        public int account_id { get; set; }
        public string password { get; set; }

        public List<int> list_purchase { get; set; }

        public User(String indexNo)
        {
            PartitionKey = "User";
            RowKey = indexNo;
            list_purchase = new List<int>();
        }
        public User() 
        {
            list_purchase = new List<int>();
        }
    }
}
