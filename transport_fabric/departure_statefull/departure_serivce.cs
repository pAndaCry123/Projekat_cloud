using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departure_statefull
{
    public class departure_serivce : IDepratire
    {
        departure_table_context context;

        public departure_serivce()
        {
            context = new departure_table_context();
            add();
        }
        private void add()
        {
            for (int i = 0; i < 10; i++)
            {

                Departure depo = new Departure(i.ToString()) { id = i,ticket_price = (i+1)*20, total_tickets = 100, free_ticket_slots=100 };
                depo.type = ((type_transport)(i % 3)).ToString();
                depo.day_departure = DateTime.Today;
                depo.return_date = depo.day_departure.AddDays(i+1);
                context.add_departure(depo);
            }
        }
    }
}
