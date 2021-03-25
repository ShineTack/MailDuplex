using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using MailService.Services;
using MailServicesAndModels.Services.MessageServices;
using MailServicesAndModels.Services.UserLoginServices;
using MailServicesAndModels.Services.UserRegistrationServices;
using MailServicesAndModels.Services.UserServices;

namespace MailService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mail Server";
            Console.WriteLine("Server work");

            //initialize hosts
            ServiceHost userRegistrationHost = GetServiceHost(
                typeof(UserRegistrationService),
                typeof(IUserRegistrationService),
                new WSDualHttpBinding(),
                "http://localhost:8080/IRegistrationService"
                );
            ServiceHost userLoginHost = GetServiceHost(
                typeof(UserLoginService),
                typeof(IUserLoginService),
                new WSDualHttpBinding(),
                "http://localhost:8080/ILoginService"
                );
            ServiceHost userHost = GetServiceHost(
                typeof(UserService),
                typeof(IUserService),
                new WSDualHttpBinding(),
                "http://localhost:8080/IUserService"
                );
            ServiceHost messageServiceHost = GetServiceHost(
                typeof(MessageService),
                typeof(IMessageService),
                new WSDualHttpBinding(),
                "http://localhost:8080/IMessageService"
                );

            //start registration host
            userRegistrationHost.Open();
            Console.WriteLine("-> User registration host open");

            //start login host
            userLoginHost.Open();
            Console.WriteLine("-> User login host open");

            //start user host
            userHost.Open();
            Console.WriteLine("-> User host open");

            //start message host
            messageServiceHost.Open();
            Console.WriteLine("-> Message host open");

            Console.WriteLine("Click Enter for stop server");
            Console.ReadLine();

            //Close hosts
            userRegistrationHost.Close();
            userLoginHost.Close();
            userHost.Close();
            messageServiceHost.Close();
            Console.WriteLine("-> All hosts closed");
        }

        static ServiceHost GetServiceHost(Type serviceType, Type contractType, Binding binding, string addres)
        {
            ServiceHost host = new ServiceHost(serviceType);
            host.AddServiceEndpoint(
                contractType,
                binding,
                addres
                );
            return host;
        }
    }
}
