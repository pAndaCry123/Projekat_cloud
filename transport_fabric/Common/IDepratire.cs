using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IDepratire
    {
        [OperationContract]
        Task<List<Departure>> return_all_departures();

        [OperationContract]
        Task<List<Departure>> return_filtered_departures(string type,string tickets,DateTime date);

        [OperationContract]
        Task<Departure> return_departure(int id_deparute, int count);

        [OperationContract]
        Task update_deprature(int id_deparute, int count);

        [OperationContract]
        Task retrive_deprature(int id_deparute, int count);


        [OperationContract]
        Task add_departure(type_transport transport, double ticket_price, int total_tickets, DateTime departure_day, double lat, double lon);
        [OperationContract]
        Task add_departure_dict(Departure departure);
    }
}
