using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using MailServicesAndModels.Services.MessageServices;
using MailServicesAndModels.Services.UserServices;
using Message = MailServicesAndModels.Models.Message;
using MailServicesAndModels.Models;
using MailClient.Reposes;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Threading;
using Timer = System.Threading.Timer;

namespace MailClient
{
    public partial class MainWindow : Form, IMessageCallback, IUserCallback
    {
        private IUserService userService;
        private IMessageService messageService;
        private Timer timer;
        private TimerCallback getInboxMessages;
        private TimerCallback getSentMessages;
        public MainWindow()
        {
            InitializeComponent();
            messageService = new DuplexChannelFactory<IMessageService>(
                new InstanceContext(this),
                new WSDualHttpBinding(),
                "http://localhost:8080/IMessageService"
                ).CreateChannel();
            userService = new DuplexChannelFactory<IUserService>(
                new InstanceContext(this),
                new WSDualHttpBinding(),
                "http://localhost:8080/IUserService"
                ).CreateChannel();
            getInboxMessages = new TimerCallback((o) =>
            {
                messageService.FindMessagesWhereRecipient(UserRepo.currentUser);
            });
            getSentMessages = new TimerCallback((o) =>
            {
                messageService.FindMessagesWhereSender(UserRepo.currentUser);
            });
            newMessageButton.Click += NewMessageButton_Click;
            s.SelectedIndexChanged += MailDirsListBox_SelectedIndexChanged;
            new Login().ShowDialog();
            Text = "Mail - " + UserRepo.currentUser.Username;
            userService.GetAllUsers();
            timer = new Timer(getInboxMessages, new object(), 0, 15000);
        }

        private void MailDirsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (s.SelectedIndex == 0)
            {
                timer.Dispose();
                timer = new Timer(getInboxMessages, new object(), 0, 15000);
            }
            else
            {
                timer.Dispose();
                timer = new Timer(getSentMessages, new object(), 0, 15000);
            }
        }

        private void NewMessageButton_Click(object sender, EventArgs e)
        {
            new NewMessage(messageService).ShowDialog();
        }

        public void MessageSended(Message message)
        {
            MessageBox.Show("Message sended");
        }

        public void SetAllUsers(List<User> users)
        {
            UserRepo.users = users;
        }

        public void SetInboxMessages(List<Message> messages)
        {

            gridControl1.DataSource = (from message in messages
                                       orderby message.SendDate descending
                                       select new
                                       {
                                           SendDate = message.SendDate,
                                           Sender = message.Sender,
                                           Recipient = message.Recipient,
                                           MessageHeader = message.MessageHeader
                                       }).ToList();

        }

        public void SetSentMessages(List<Message> messages)
        {

            gridControl1.DataSource = (from message in messages
                                       orderby message.SendDate descending
                                       select new
                                       {
                                           SendDate = message.SendDate,
                                           Sender = message.Sender,
                                           Recipient = message.Recipient,
                                           MessageHeader = message.MessageHeader
                                       }).ToList();

        }
    }
}