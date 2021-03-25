using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Models;
namespace MailServicesAndModels.Services.MessageServices
{
    public interface IMessageCallback
    {
        [OperationContract(IsOneWay = true)]
        void SetInboxMessages(List<Message> messages);

        [OperationContract(IsOneWay = true)]
        void SetSentMessages(List<Message> messages);

        [OperationContract(IsOneWay = true)]
        void MessageSended(Message message);
    }
}
