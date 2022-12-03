using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_statefull
{
    public class bank_service : IBank
    {
        bank_table_context context;

        public bank_service()
        {
            this.context = new bank_table_context();
          
        }
        private void add()
        {
            for (int i = 0; i < 5; i++)
            {
                Account aa = new Account(i.ToString()) { account_id = i + 1, amount = (i + 1) * 1000 };
                context.add_account(aa);
            }
        }

        public async Task<double> get_resources(int account_id)
        {
            return await context.return_resources(account_id);
        }
    }
}
