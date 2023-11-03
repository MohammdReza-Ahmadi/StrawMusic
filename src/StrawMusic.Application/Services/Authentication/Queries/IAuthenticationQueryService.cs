using ErrorOr;

namespace StrawMusic.Application.Services.Authentication;

public interface IAuthenticationQueryService
{
      ErrorOr<AuthenticationResult> Login( string email, string password);
}