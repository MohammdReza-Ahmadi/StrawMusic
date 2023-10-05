using ErrorOr;
using Helios.Api.Controllers;
using Helios.Application.Authentication.Commands.Register;
using Helios.Application.Authentication.Common;
using Helios.Application.Authentication.Queries.Login;
using Helios.Contracts.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Helios.Api.Controller;


[Route("auth")]
public class AuthenticationController: ApiController
{

    private readonly ISender _mediator;
    private readonly IMapper _mapper;
    public AuthenticationController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        // var command = new RegisterCommand(request.FirstName,request.LastName,request.Email,request.Password);
        var command = _mapper.Map<RegisterCommand>(request);

         ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);
            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResult>(authResult)),
                errors => Problem(errors));
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        // var query = new LoginQuery(request.Email,request.Password);
        var query = _mapper.Map<LoginQuery>(request);
        var authResult = await _mediator.Send(query);

        if(authResult.IsError && authResult.FirstError == Domain.Common.Errors.Errors.Authentication.InvalidCredentials)
        {
            return Problem(
                statusCode: StatusCodes.Status401Unauthorized,
                title: authResult.FirstError.Description);
        }

        var response = new AuthenticationResponse(
            authResult.Value.User.Id,
            authResult.Value.User.FirstName,
            authResult.Value.User.LastName,
            authResult.Value.User.Email,
            authResult.Value.Token
        );
        return Ok(response);
    }
    
}
