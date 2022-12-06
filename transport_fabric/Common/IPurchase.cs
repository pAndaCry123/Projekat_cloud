using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IPurchase
    {

        [OperationContract]
        Task<int> create_pruchase(int id_deparutere, int count,string username);

        [OperationContract]
        Task<bool> cancel_purchase(int purchase_id);

        [OperationContract]
        Task<Purchase> purchase_get(int purchase_id);

        [OperationContract]
        Task delete_purchase(Purchase purchase);

    }
}
