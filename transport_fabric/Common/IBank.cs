using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IBank
    {

        [OperationContract]
        Task<double> get_resources(int account_id);
        [OperationContract]
        Task update_user_account(int id_account, double amount);


        [OperationContract]
        Task<Account> account_get(int account_id);

        [OperationContract]
        Task update_account(int account_id,double amount);
    }
}
