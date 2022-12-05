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
        public async Task<List<Departure>> retrun_all_departures()
        {
            var results = from g in _table.CreateQuery<Departure>()
                          where g.PartitionKey == "Departure"
                          select g;

            return results.ToList();
        }
        public async Task<Departure> retrun_one_departure(int departure_id,int count)
        {
            var results = from g in _table.CreateQuery<Departure>()
                          where g.PartitionKey == "Departure"
                          select g;

            foreach (var item in results)
            {
                if (item.id == departure_id && item.free_ticket_slots - count >= 0)
                    return item;
            }
            return null;
        }


        public async Task<List<Departure>> retrun_filtered_departures(string type ,  string tickets, DateTime date )
        {
            var results = from g in _table.CreateQuery<Departure>()
                          where g.PartitionKey == "Departure"
                          select g;
            //List<Departure> ret = results.ToList();
            //List<Departure> index = new List<Departure>();
            //bool flag = false;
            //for (int i = 0; i < ret.Count -1; i++)
            //{
            //    var item = ret[i];
            //    if (!item.type.Equals(type))
            //        flag = true;
            //    if (tickets != null && tickets.Equals("on") && !(item.free_ticket_slots > 0))
            //        flag = true;

            //    DateTime dateTime = DateTime.Parse(item.day_departure);
            //    if (date != null && (DateTime.Compare(dateTime, date) < 0))
            //        flag = true;

            //    if (flag)
            //        index.Add(item);
            //}

            //foreach (var item in index)
            //{
            //    ret.Remove(item);
            //}
            //&& 
            //(DateTime.Compare(DateTime.Parse(x.day_departure), date) > 0)
            var ret = results.Where(x => x.type.Equals(type) );
            if (tickets.Equals("on"))
               ret = ret.Where(x => x.free_ticket_slots > 151);

            DateTime dateBound = DateTime.Parse("1/1/0001 12:00:00 AM");
            if (date != dateBound)
            {
                List<Departure> datas = new List<Departure>();
                foreach (var item in ret)
                {
                    if (DateTime.Compare(DateTime.Parse(item.day_departure), DateTime.Parse(date.ToShortDateString())) > 0)
                        datas.Add(item);
                }

                return datas;
            }
                
            return ret.ToList();
        }
        public void add_user(Departure new_user)
        {
            TableOperation insertOperation = TableOperation.InsertOrReplace(new_user);
            _table.Execute(insertOperation);
        }
        public async Task update_departure(int departure_id, int count)
        {
            var results = from g in _table.CreateQuery<Departure>()
                          where g.PartitionKey == "Departure"
                          select g;

            foreach (var item in results)
            {
                if (item.id == departure_id)
                {
                    item.free_ticket_slots -= count;
                    TableOperation insertOperation = TableOperation.InsertOrReplace(item);
                    _table.Execute(insertOperation);
                }
            }
        }
    }
}
