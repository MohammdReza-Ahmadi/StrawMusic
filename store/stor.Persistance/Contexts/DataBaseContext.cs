using Microsoft.EntityFrameworkCore;
using sore.Domin.Entites.Users;
using stor.Applications.Interface.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stor.Persistance.Contexts
{
    public class DataBaseContext:DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<User> Users { get; set; }  
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UsersRoles { get; set; }

        
    }
}
