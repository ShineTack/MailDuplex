using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Models;


namespace MailServicesAndModels.Services.MessageServices
{
    [ServiceContract(CallbackContract = typeof(IMessageCallback))]
    public interface IMessageService
    {
        [OperationContract(IsOneWay = true)]
        void FindMessagesWhereSender(User user);

        [OperationContract(IsOneWay = true)]
        void FindMessagesWhereRecipient(User user);

        [OperationContract(IsOneWay = true)]
        void SendMessage(Message message);
    }
}
