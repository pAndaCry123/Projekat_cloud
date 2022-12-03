using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_statefull
{
    public class user_service : ITransactions
    {
        //For now just cover table and constantly write data to table :D
        user_table_context context;

        public user_service()
        {
            context = new user_table_context();
        }

        public async Task<bool> check_user(string username, string password)
        {
            return await context.return_user(username, password) != null;
        }

        public async Task<bool> create_user(string username, string email, string password, int account_id)
        {
            if (await context.check_user(username, password))
            {
                return false;
            }
            else
            {
                string row = context.return_count_users();
                context.add_user(new User(row) { username = username, email = email, password = password, account_id = account_id });
                return true;
            }
        }
    }
}
