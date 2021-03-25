using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Services.UserLoginServices;
using MailServicesAndModels.Models;
using System.ServiceModel;

namespace MailService.Services
{
    class UserLoginService : IUserLoginService
    {
        private MailDbContext dbContext = MailDbContext.DbContext;
        private IUserLoginCallback loginCallback =
            OperationContext.Current.GetCallbackChannel<IUserLoginCallback>();
        public void Login(string username, string password)
        {
            User userFromDb = 
                dbContext.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (userFromDb != null)
            {
                loginCallback.UserFound(userFromDb);
                Console.WriteLine($"-> User {userFromDb.Username} login in system");
            }
            else
            {
                loginCallback.UserNotFound();
                Console.WriteLine("-> User not found in system");
            }
        }
    }
}
