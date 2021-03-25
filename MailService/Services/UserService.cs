using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Services.UserServices;
using MailServicesAndModels.Models;
using System.ServiceModel;

namespace MailService.Services
{
    class UserService : IUserService
    {
        private MailDbContext dbContext = MailDbContext.DbContext;
        private IUserCallback userCallback =
            OperationContext.Current.GetCallbackChannel<IUserCallback>();
        public async void GetAllUsers()
        {
            List<User> users = await Task.Run(() => 
            {
                return (from user in dbContext.Users
                        select user).ToList();
            });
            userCallback.SetAllUsers(users);
            Console.WriteLine("-> Get all users for client");
        }
    }
}
