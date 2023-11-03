using ErrorOr;

namespace Helios.Application.Services.Authentication;

public interface IAuthenticationCommandService
{
   ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
}