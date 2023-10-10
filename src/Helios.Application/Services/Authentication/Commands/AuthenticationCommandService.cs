using ErrorOr;
using Helios.Application.Common.Interfaces.Authentication;
using Helios.Application.Common.Interfaces.Persistence;
using Helios.Domain.Common.Errors;
using Helios.Domain.User;

namespace Helios.Application.Services.Authentication;

public class AuthenticationCommandService : IAuthenticationCommandService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepsitory _userRepsitory;
    public AuthenticationCommandService(IJwtTokenGenerator jwtTokenGenerator,IUserRepsitory userRepsitory)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepsitory = userRepsitory;
    }

    public ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password)
    {
        if(_userRepsitory.GetUserByEmail(email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

      var user = new User{
        FirstName = firstName,
        LastName = lastName,
        Email = email,
        Password = password
      };
      _userRepsitory.AddUser(user);

      var token = _jwtTokenGenerator.GeneratorToken(user);
      return new AuthenticationResult(user, token);
    }
}