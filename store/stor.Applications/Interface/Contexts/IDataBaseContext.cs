using Microsoft.EntityFrameworkCore;
using sore.Domin.Entites.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stor.Applications.Interface.Contexts
{
    public interface IDataBaseContext
    {
         DbSet<User> Users { get; set; }
         DbSet<Role> Roles { get; set; }
         DbSet<UserInRole> UsersRoles { get; set; }


    }
}
