using DevExpress.XtraEditors;
using MailServicesAndModels.Models;
using MailServicesAndModels.Services.UserLoginServices;
using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace MailDevExpressClient
{
    public partial class Login : Form, IUserLoginCallback
    {
        private IUserLoginService userLoginService;
        private User user;
        public Login(User user)
        {
            InitializeComponent();
            this.user = user;
            userLoginService = new DuplexChannelFactory<IUserLoginService>(
                new InstanceContext(this),
                new WSDualHttpBinding(),
                "http://localhost:8080/ILoginService"
                ).CreateChannel();
            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ChangeElementsEnabled(false);
            userLoginService.Login(
                usernameTextEdit.Text,
                passwordTextEdit.Text
                );
        }

        public void UserFound(User user)
        {
            this.user = user;
            Close();
        }

        private void ChangeElementsEnabled(bool state)
        {
            usernameTextEdit.Enabled = state;
            passwordTextEdit.Enabled = state;
            loginButton.Enabled = state;
            registrationButton.Enabled = state;
        }

        public void UserNotFound()
        {
            XtraMessageBox.Show("User not found");
            ChangeElementsEnabled(true);
        }
    }
}
