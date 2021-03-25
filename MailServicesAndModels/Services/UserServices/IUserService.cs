using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Models;

namespace MailServicesAndModels.Services.UserServices
{
    [ServiceContract(CallbackContract = typeof(IUserCallback))]
    public interface IUserService
    {
        [OperationContract(IsOneWay = true)]
        void GetAllUsers();
    }
}
