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

        public async Task hit()
        {
            Console.WriteLine("Usao sam ");
        }
    }
}
