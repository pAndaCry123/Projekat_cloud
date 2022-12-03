using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Account    : TableEntity
    {
        public int account_id { get; set; }
        public double amount { get; set; }

        public Account(String indexNo)
        {
            PartitionKey = "Account";
            RowKey = indexNo;
        }
        public Account()
        {
        }
    }
}
