using ErrorOr;
using StrawMusic.Application.Common.Interfaces.Authentication;
using StrawMusic.Application.Common.Interfaces.Persistence;
using StrawMusic.Domain.Common.Errors;
using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Application.Services.Authentication;

public class AuthenticationQueryService : IAuthenticationQueryService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepsitory _userRepsitory;
    public AuthenticationQueryService(IJwtTokenGenerator jwtTokenGenerator,IUserRepsitory userRepsitory)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepsitory = userRepsitory;
    }
    public ErrorOr<AuthenticationResult> Login(string email, string password)
    {
       if(_userRepsitory.GetUserByEmail(email) is not UserEntity user)
       {
        // throw new Exception("User with given email already exists.");
        return Errors.Authentication.InvalidCredentials;
       } 

       if(user.Password != password)
       {
            // throw new Exception("Password not valid.");
            return new[]{ Errors.Authentication.InvalidCredentials};
       }

       var token = _jwtTokenGenerator.GeneratorToken(user);

       return new AuthenticationResult(user, token);


    }

}