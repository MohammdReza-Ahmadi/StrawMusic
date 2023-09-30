using Helios.Domain.User;

namespace Helios.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GeneratorToken(User user);
}