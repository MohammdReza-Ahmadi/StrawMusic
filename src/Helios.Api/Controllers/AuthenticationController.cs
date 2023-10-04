using ErrorOr;
using Helios.Api.Controllers;
using Helios.Application.Authentication.Commands.Register;
using Helios.Application.Authentication.Common;
using Helios.Application.Authentication.Queries.Login;
using Helios.Contracts.Authentication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Helios.Api.Controller;


[Route("auth")]
public class AuthenticationController: ApiController
{

    private readonly ISender _mediator;
    public AuthenticationController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(request.FirstName,request.LastName,request.Email,request.Password);

         ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);
        // ErrorOr<AuthenticationResult> authResult = _authenticationCommandService.Register(
        //     request.FirstName,
        //     request.LastName,
        //     request.Email,
        //     request.Password);

            return authResult.Match(
                authResult => Ok(MapAuthResult(authResult)),
                errors => Problem(errors));
            //Error FluentResult Application
            // if(registerResult.IsSuccess)
            // {
            //     return Ok(MapAuthResult(registerResult.Value));
            // }
            // var firstError = registerResult.Errors[0];

            // if(firstError is DuplicateEmailError)
            // {
            //     return Problem(statusCode: StatusCodes.Status409Conflict, detail: "Email already exsist."));
            // }

            // return Problem();
        // return registerResult.Match(
        //     authResult => Ok(MapAuthResult(authResult)),
        //     error => Problem(statusCode: (int)error.StatusCode,title: error.ErrorMessage)
        // );
    }

    private object? MapAuthResult(AuthenticationResult authResult)
    {
            return new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
        );
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginRequest request)
    {
        var query = new LoginQuery(request.Email,request.Password);
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
