using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Services.MessageServices;
using MailServicesAndModels.Models;
using System.ServiceModel;

namespace MailService.Services
{
    class MessageService : IMessageService
    {
        private MailDbContext dbContext = MailDbContext.DbContext;
        private IMessageCallback messageCallback =
              OperationContext.Current.GetCallbackChannel<IMessageCallback>();
        public async void FindMessagesWhereRecipient(User user)
        {
            
            messageCallback.SetInboxMessages(await Task<List<Message>>.Run(() =>
            {
                return (from message in dbContext.Messages
                        where message.Recipient.Id == user.Id
                        select message).ToList() as List<Message>;
            }));
            Console.WriteLine($"-> User {user.Username} requested all messges where they recipient");
        }

        public async void FindMessagesWhereSender(User user)
        {
            List<Message> messages = await Task<List<Message>>.Run(() => 
            {
                return (from message in dbContext.Messages
                        where message.Sender.Id == user.Id
                        select message).ToList() as List<Message>;
            });
            messageCallback.SetSentMessages(messages);
            Console.WriteLine($"-> User {user.Username} requested all messges where they sender");
        }

        public void SendMessage(Message message)
        {
            dbContext.Messages.Add(new Message() 
            { 
                SendDate = message.SendDate,
                Recipient = dbContext.Users.First(u => u.Id == message.Recipient.Id),
                Sender = dbContext.Users.First(u => u.Id == message.Sender.Id),
                MessageBody = message.MessageBody,
                MessageHeader = message.MessageHeader
            });
            dbContext.SaveChanges();
            Console.WriteLine($"-> User {message.Sender.Username} send message to {message.Recipient.Username}");
        }
    }
}
