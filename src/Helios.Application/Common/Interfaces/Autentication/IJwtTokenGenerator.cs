using Helios.Domain.User;

namespace Helios.Application.Common.Interfaces.Autentication;

public interface IJwtTokenGenerator
{
    string GeneratorToken(User user);
}