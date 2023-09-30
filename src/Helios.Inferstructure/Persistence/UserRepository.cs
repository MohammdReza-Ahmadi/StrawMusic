using Helios.Application.Common.Interfaces.Persistence;
using Helios.Domain.User;

namespace Helios.Infrastructure.Persistence;

public class UserRepository : IUserRepsitory
{
    private static readonly List<User> _user = new ();
    public void AddUser(User user)
    {
        _user.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
       return _user.SingleOrDefault(e=>e.Email == email);
    }
}