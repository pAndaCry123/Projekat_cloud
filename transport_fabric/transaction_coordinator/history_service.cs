using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction_coordinator
{
    public class history_service : IHistory
    {
        history_table_context context;

        public history_service()
        {
            context = new history_table_context();
        }

        public async Task load_to_table(List<Purchase>list)
        {
            await context.add_to_history_table(list);
        }

        public async Task<List<Purchase>> return_all_purchases()
        {
            return await context.return_all_purchase();
        }
    }
}
