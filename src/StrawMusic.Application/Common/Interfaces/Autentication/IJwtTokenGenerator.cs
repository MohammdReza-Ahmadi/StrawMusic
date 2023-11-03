using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GeneratorToken(UserEntity user);
}