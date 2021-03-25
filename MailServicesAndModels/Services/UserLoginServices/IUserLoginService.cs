using MailServicesAndModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesAndModels.Services.UserLoginServices
{
    [ServiceContract(CallbackContract = typeof(IUserLoginCallback))]
    public interface IUserLoginService
    {
        [OperationContract(IsOneWay = true)]
        void Login(string username, string password);
    }
}
