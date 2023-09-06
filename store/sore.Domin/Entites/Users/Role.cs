using System.Collections.Generic;

namespace sore.Domin.Entites.Users
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserInRole> userInRoles { get; set; }    
    }
}
