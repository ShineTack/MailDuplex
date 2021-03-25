using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailServicesAndModels.Models;
using MailServicesAndModels.Services.MessageServices;

namespace MailClient
{
    public partial class NewMessage : Form
    {
        private IMessageService service;
        public NewMessage(IMessageService service)
        {
            InitializeComponent();
            usersComboBox.DataSource = Reposes.UserRepo.users.Select(u => u.Username).ToList();
            this.service = service;
            sendMessage.Click += SendMessage_Click;
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            User recipient = Reposes.UserRepo.users.First(u => u.Username == usersComboBox.Text);
            MailServicesAndModels.Models.Message message =
                new MailServicesAndModels.Models.Message()
                {
                    SendDate = DateTime.Now,
                    Recipient = recipient,
                    Sender = Reposes.UserRepo.currentUser,
                    MessageHeader = messageHeaderTextBox.Text,
                    MessageBody = messageBodyTextBox.Text
                };
            service.SendMessage(message);
            Close();
        }
    }
}
