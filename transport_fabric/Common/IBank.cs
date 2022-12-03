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
    }
}
