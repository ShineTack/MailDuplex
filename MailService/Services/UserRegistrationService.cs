using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Services.UserRegistrationServices;
using MailServicesAndModels.Models;
using System.ServiceModel;

namespace MailService.Services
{
    class UserRegistrationService : IUserRegistrationService
    {
        private MailDbContext dbContext = MailDbContext.DbContext;
        private IUserRegistrationCallback registrationCallback =
            OperationContext.Current.GetCallbackChannel<IUserRegistrationCallback>();
        public void AddNewUSer(string username, string password, string fullName = null)
        {
            User user = new User()
            {
                Username = username,
                FullName = fullName,
                Password = password
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            registrationCallback.LoginNewUser(user);
            Console.WriteLine($"-> User {user.Username} registered in system");
        }
    }
}
