using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum type_transport { Autobus = 0,Plane = 1 , Train = 2}
    public class Departure : TableEntity
    {
        public int id { get; set; }
        public string type { get; set; }
        public string weather { get; set; }
        public double ticket_price { get; set; }
        public string day_departure { get; set; }
        public string return_date { get; set; }
        public int total_tickets { get; set; }
        public int free_ticket_slots { get; set; }


        public Departure(String indexNo)
        {
            PartitionKey = "Departure";
            RowKey = indexNo;
        }
        public Departure()
        {
        }
    }
}
