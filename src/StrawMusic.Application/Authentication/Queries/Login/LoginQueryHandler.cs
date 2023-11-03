using ErrorOr;
using Helios.Application.Authentication.Common;
using Helios.Application.Common.Interfaces.Authentication;
using Helios.Application.Common.Interfaces.Persistence;
using Helios.Domain.User;
using MediatR;

namespace Helios.Application.Authentication.Queries.Login;

public class LoginQueryHandler : 
IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepsitory _userRepsitory;

    public LoginQueryHandler
    (IJwtTokenGenerator jwtTokenGenerator,
     IUserRepsitory userRepsitory)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepsitory = userRepsitory;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery query, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;


if(_userRepsitory.GetUserByEmail(query.Email) is not User user)
       {
        // throw new Exception("User with given email already exists.");
        return Domain.Common.Errors.Errors.Authentication.InvalidCredentials;
       } 

       if(user.Password != query.Password)
       {
            // throw new Exception("Password not valid.");
            return new[]{Domain.Common.Errors.Errors.Authentication.InvalidCredentials};
       }

       var token = _jwtTokenGenerator.GeneratorToken(user);

       return new AuthenticationResult(user, token);

    }
}
