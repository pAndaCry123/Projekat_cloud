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
        Task commit(Departure departure,User user,int count);

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


        [OperationContract]
        Task<bool> cancel_purchase(int purchase_id);


        [OperationContract]
        Task commit_purchase(Purchase purchase);

        [OperationContract]
        Task<List<Purchase>> return_history_purchases();


        [OperationContract]
        Task<List<Purchase>> filter_history_purchases(string date, string tickets);

        [OperationContract]
        Task add_departure(type_transport transport, double ticket_price, int total_tickets, DateTime departure_day, double lat, double lon);
    }
}
