using ErrorOr;
using StrawMusic.Application.Authentication.Common;
using MediatR;

namespace StrawMusic.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password):IRequest<ErrorOr<AuthenticationResult>>;