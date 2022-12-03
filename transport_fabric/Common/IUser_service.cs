﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IUser_service
    {
        [OperationContract]
        Task<bool> create_user(string username, string email, string password, int account_id);
        [OperationContract]
        Task<bool> check_user(string username, string password);
    }
}
