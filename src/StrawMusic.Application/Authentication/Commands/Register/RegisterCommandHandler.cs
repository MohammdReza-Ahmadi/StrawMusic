using ErrorOr;
using StrawMusic.Application.Authentication.Common;
using StrawMusic.Application.Common.Interfaces.Authentication;
using StrawMusic.Application.Common.Interfaces.Persistence;
using StrawMusic.Domain.UserEntity;
using MediatR;

namespace StrawMusic.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : 
IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepsitory _userRepsitory;

    public RegisterCommandHandler
    (IJwtTokenGenerator jwtTokenGenerator,
     IUserRepsitory userRepsitory)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepsitory = userRepsitory;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
      await Task.CompletedTask;
        if(_userRepsitory.GetUserByEmail(command.Email) is not null)
        {
            //throw new Exception("User with given email already exists.");
            // return Result.Fail<AuthenticationResult>(new[] {new DuplicateEmailError() });
            return Domain.Common.Errors.Errors.User.DuplicateEmail;
        }

      var user = new UserEntity{
        FirstName = command.FirstName,
        LastName = command.LastName,
        Email = command.Email,
        Password = command.Password
      };
      
      _userRepsitory.AddUser(user);

      var token = _jwtTokenGenerator.GeneratorToken(user);
      return new AuthenticationResult(user, token);
    }
}
