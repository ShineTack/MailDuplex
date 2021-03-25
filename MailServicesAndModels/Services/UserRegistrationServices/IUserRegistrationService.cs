using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesAndModels.Services.UserRegistrationServices
{
    [ServiceContract(CallbackContract = typeof(IUserRegistrationCallback))]
    public interface IUserRegistrationService
    {
        [OperationContract(IsOneWay = true)]
        void AddNewUSer(string username, string password, string fullName = null);
    }
}
