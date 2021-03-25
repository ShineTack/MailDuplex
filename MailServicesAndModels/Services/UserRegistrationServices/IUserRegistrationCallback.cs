using MailServicesAndModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesAndModels.Services.UserRegistrationServices
{
    public interface IUserRegistrationCallback
    {
        [OperationContract(IsOneWay = true)]
        void LoginNewUser(User user);
    }
}
