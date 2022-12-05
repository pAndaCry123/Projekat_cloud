using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchase_statefull
{
    public class purchase_service : IPurchase
    {
        pur_table_context context;

        public purchase_service()
        {
            context = new pur_table_context();
        }

        public async Task<int> create_pruchase(int id_deparutere, int count, string userneme)
        {
            string row_key = context.return_count_purchase();
            Purchase purchase = new Purchase(row_key) {purchase_id = int.Parse(row_key), count_tickets = count, departure_id = id_deparutere, ticket_buy = DateTime.Now.ToShortDateString(),username = userneme };

            await context.add_new_pruchase(purchase);

            return int.Parse(row_key);
        }
    }
}
