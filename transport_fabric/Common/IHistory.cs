using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IHistory
    {

        [OperationContract]
        Task load_to_table(List<Purchase>list);
        [OperationContract]
        Task<List<Purchase>> return_all_purchases();
    }
}
