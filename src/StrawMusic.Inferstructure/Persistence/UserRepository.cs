using StrawMusic.Application.Common.Interfaces.Persistence;
using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Infrastructure.Persistence;

public class UserRepository : IUserRepsitory
{
    private static readonly List<UserEntity> _user = new ();
    public void AddUser(UserEntity user)
    {
        _user.Add(user);
    }

    public UserEntity? GetUserByEmail(string email)
    {
       return _user.SingleOrDefault(e=>e.Email == email);
    }
}