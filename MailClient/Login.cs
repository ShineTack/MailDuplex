using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailServicesAndModels.Models;
using MailServicesAndModels.Services.UserLoginServices;
using MailClient.Reposes;
using System.ServiceModel;

namespace MailClient
{
    public partial class Login : Form, IUserLoginCallback
    {
        private IUserLoginService userLoginService;
        public Login()
        {
            InitializeComponent();
            userLoginService = ChannelBuilder.GetChannelFactory<IUserLoginService>(
                new InstanceContext(this),
                new WSDualHttpBinding(),
                "http://localhost:8080/ILoginService"
                ).CreateChannel();
            loginButton.Click += LoginButton_Click;
            registrationButton.Click += RegistrationButton_Click;
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            new Registration().ShowDialog();
            Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ChangeEnabled(false);
            userLoginService.Login(
                usernameTextBox.Text,
                passwordTextBox.Text
                );
        }

        public void UserFound(User user)
        {
            UserRepo.currentUser = user;
            this.Close();
        }

        public void UserNotFound()
        {
            MessageBox.Show("User not found!");
            ChangeEnabled(true);
        }

        private void ChangeEnabled(bool status)
        {
            usernameTextBox.Enabled = status;
            passwordTextBox.Enabled = status;
            registrationButton.Enabled = status;
            loginButton.Enabled = status;
        }
    }
}
