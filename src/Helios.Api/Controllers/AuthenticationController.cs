using FluentResults;
using Helios.Application.Common.Errors;
using Helios.Application.Services.Authentication;
using Helios.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Helios.Api.Controller;

[ApiController]
[Route("auth")]
public class AuthenticationController: ControllerBase
{

    private readonly IAuthenticationService _authenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        Result<AuthenticationResult> registerResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
            if(registerResult.IsSuccess)
            {
                return Ok(MapAuthResult(registerResult.Value));
            }
            var firstError = registerResult.Errors[0];

            if(firstError is DuplicateEmailError)
            {
                return Problem(statusCode: StatusCodes.Status409Conflict, detail: "Email already exsist."));
            }

            return Problem();
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
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.Login(request.Email,request.Password);

        var response = new AuthenticationResponse(
            authResult.User.Id,
            authResult.User.FirstName,
            authResult.User.LastName,
            authResult.User.Email,
            authResult.Token
        );
        return Ok(response);
    }
    
}
