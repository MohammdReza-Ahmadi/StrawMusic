using Helios.Application.Common.Interfaces.Authentication;
using Helios.Application.Common.Interfaces.Persistence;
using Helios.Domain.User;

namespace Helios.Application.Services.Authentication;

public class AuthenticationService : IAutenticatinService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepsitory _userRepsitory;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator,IUserRepsitory userRepsitory)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepsitory = userRepsitory;
    }
    public AuthenticationResult Login(string email, string password)
    {
       if(_userRepsitory.GetUserByEmail(email) is not User user)
       {
        throw new Exception("User with given email already exists.");
       } 

       if(user.Password != password)
       {
            throw new Exception("Password not valid.");
       }

       var token = _jwtTokenGenerator.GeneratorToken(user);

       return new AuthenticationResult(user, token);


    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        if(_userRepsitory.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with given email already exists.");
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