using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailClient.Reposes;
using MailServicesAndModels.Services.MessageServices;
using MailServicesAndModels.Services.UserLoginServices;
using MailServicesAndModels.Services.UserRegistrationServices;
using MailServicesAndModels.Services.UserServices;

namespace MailClient
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
