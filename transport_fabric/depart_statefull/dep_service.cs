using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depart_statefull
{
    public class dep_service : IDepratire
    {
        dep_table_context context;

        public dep_service()
        {
            context = new dep_table_context();
            add();
        }

        public async Task hit()
        {
            Console.WriteLine("Usao sam ovde nema errora mrtvi sf je glup");
        }

        private void add()
        {
            for (int i = 0; i < 10; i++)
            {
                
                Departure dd = new Departure(i.ToString()) { id = i+1 };
                dd.day_departure = DateTime.Now.AddDays(2).ToString();
                dd.return_date = DateTime.Now.AddDays(10).ToString();
                dd.ticket_buy = DateTime.Now.ToString();
                dd.ticket_price = (i + 1) * 20;
                dd.total_tickets = 150;
                dd.free_ticket_slots = 150;
                context.add_user(dd);
            }
        }
    }
}
