using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface ITransactions 
    {
        [OperationContract]
        Task commit(Departure departure,User user);

        [OperationContract]
        Task<bool> prepare(string username, int id_departure, int count);
        [OperationContract]
        Task rollback();
        [OperationContract]
        Task<bool> create_user(string username, string email, string password, int account_id);
        [OperationContract]
        Task<bool> check_user(string username, string password);
        [OperationContract]
        Task<List<Departure>> return_all_departures();

        [OperationContract]
        Task<List<Departure>> return_filtered_departures(string type, string tickets, DateTime date);
    }
}
