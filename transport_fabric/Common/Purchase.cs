using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Purchase :TableEntity
    {

        public int purchase_id { get; set; }
        public int departure_id { get; set; }
        public string ticket_buy { get; set; }
        public string username { get; set; }
        public int count_tickets { get; set; }

        public Purchase(String indexNo)
        {
            PartitionKey = "Purchase";
            RowKey = indexNo;
        }
        public Purchase()
        {
        }
    }
}
