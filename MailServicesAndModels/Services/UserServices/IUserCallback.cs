using MailServicesAndModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesAndModels.Services.UserServices
{
    public interface IUserCallback
    {
        [OperationContract(IsOneWay = true)]
        void SetAllUsers(List<User> users);
    }
}
