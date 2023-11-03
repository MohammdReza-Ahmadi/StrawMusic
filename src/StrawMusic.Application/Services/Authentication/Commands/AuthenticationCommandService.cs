using ErrorOr;
using StrawMusic.Application.Common.Interfaces.Authentication;
using StrawMusic.Application.Common.Interfaces.Persistence;
using StrawMusic.Domain.Common.Errors;
using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Application.Services.Authentication;

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

      var user = new UserEntity{
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