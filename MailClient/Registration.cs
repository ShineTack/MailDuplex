using System.Threading.Tasks;
using System.Windows.Forms;
using MailServicesAndModels.Services.UserRegistrationServices;
using MailServicesAndModels.Models;
using MailClient.Reposes;
using System.ServiceModel;

namespace MailClient
{
    public partial class Registration : Form, IUserRegistrationCallback
    {
        private IUserRegistrationService userRegistrationService;
        public Registration()
        {
            InitializeComponent();
            userRegistrationService = ChannelBuilder.GetChannelFactory<IUserRegistrationService>(
                new InstanceContext(this),
                new WSDualHttpBinding(),
                "http://localhost:8080/IRegistrationService"
                ).CreateChannel();
            registrationButton.Click += RegistrationButton_Click;
        }

        private void RegistrationButton_Click(object sender, System.EventArgs e)
        {
            ChangeElementsStatus(false);
            userRegistrationService.AddNewUSer(
                usernameTextBox.Text,
                passwordTextBox.Text,
                fullNameTextBox.Text
                );
        }

        public void LoginNewUser(User user)
        {
            UserRepo.currentUser = user;
            Close();
        }

        private void ChangeElementsStatus(bool status)
        {
            registrationButton.Enabled = status;
            usernameTextBox.Enabled = status;
            fullNameTextBox.Enabled = status;
            passwordTextBox.Enabled = status;
        }
    }
}
