using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailServicesAndModels.Models;
using MailServicesAndModels.Services.UserServices;
using MailServicesAndModels.Services.MessageServices;
using System.Threading;
using Timer = System.Threading.Timer;
using System.ServiceModel;

namespace MailDevExpressClient
{
    public partial class MainWindow : DevExpress.XtraBars.Ribbon.RibbonForm, IMessageCallback, IUserCallback
    {
        private IUserService userService;
        private IMessageService messageService;
        private Timer timer;
        private TimerCallback getInboxMessages;
        private TimerCallback getSentMessages;
        public static User currentUser;
        private List<User> users;
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
            new Login(currentUser).ShowDialog();
            getInboxMessages = new TimerCallback((o) =>
            {
                messageService.FindMessagesWhereRecipient(currentUser);
            });
            getSentMessages = new TimerCallback((o) =>
            {
                messageService.FindMessagesWhereSender(currentUser);
            });
            inboxMessagesButton.ItemClick += InboxMessagesButton_ItemClick;
            sentMessagesButton.ItemClick += SentMessagesButton_ItemClick;
            timer = new Timer(getInboxMessages, new object(), 0, 15_000);
        }

        private void SentMessagesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            timer.Dispose();
            timer = new Timer(getSentMessages, new object(), 0, 15_000);
        }

        private void InboxMessagesButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            timer.Dispose();
            timer = new Timer(getInboxMessages, new object(), 0, 15_000);
        }

        public void MessageSended(MailServicesAndModels.Models.Message message)
        {
            XtraMessageBox.Show("Message sended");
        }

        public void SetAllUsers(List<User> users)
        {
            this.users = users;
        }

        public void SetInboxMessages(List<MailServicesAndModels.Models.Message> messages)
        {
            messageGridView.DataSource = (from message in messages
                                          orderby message.SendDate
                                          select new 
                                          { 
                                              SendDate = message.SendDate,
                                              Sender = message.Sender,
                                              Recipient = message.Recipient,
                                              message.MessageHeader
                                          });
            bsiRecordsCount.Caption = "Messages : " + messagesGridView.DataRowCount;
        }

        public void SetSentMessages(List<MailServicesAndModels.Models.Message> messages)
        {
            messageGridView.DataSource = (from message in messages
                                          orderby message.SendDate
                                          select new
                                          {
                                              SendDate = message.SendDate,
                                              Sender = message.Sender,
                                              Recipient = message.Recipient,
                                              message.MessageHeader
                                          });
            bsiRecordsCount.Caption = "Messages : " + messagesGridView.DataRowCount;
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            messageGridView.ShowRibbonPrintPreview();
        }
    }
}