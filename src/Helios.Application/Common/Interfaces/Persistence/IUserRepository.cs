using Helios.Domain.User;

namespace Helios.Application.Common.Interfaces.Persistence;

public interface IUserRepsitory
{
    User? GetUserByEmail(string email);
    void AddUser(User user);
}