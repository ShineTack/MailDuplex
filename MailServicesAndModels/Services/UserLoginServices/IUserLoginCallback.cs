using MailServicesAndModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesAndModels.Services.UserLoginServices
{
    
    public interface IUserLoginCallback
    {
        [OperationContract(IsOneWay = true)]
        void UserFound(User user);

        [OperationContract(IsOneWay = true)]
        void UserNotFound();
    }
}
