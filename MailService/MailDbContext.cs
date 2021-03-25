using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailServicesAndModels.Models;
namespace MailService
{
    class MailDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        private static MailDbContext dbContext;
        private MailDbContext() : base("connectionString")
        {

        }

        public static MailDbContext DbContext
        {
            get
            {
                if (dbContext == null)
                {
                    dbContext = new MailDbContext();
                    return dbContext;
                }
                else return dbContext;
            }
        }
    }
}
