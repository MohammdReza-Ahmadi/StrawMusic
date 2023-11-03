using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Application.Common.Interfaces.Persistence;

public interface IUserRepsitory
{
    UserEntity? GetUserByEmail(string email);
    void AddUser(UserEntity user);
}