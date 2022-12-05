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
    }
}
