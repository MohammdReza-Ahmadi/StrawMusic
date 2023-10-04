using ErrorOr;
using Helios.Application.Authentication.Common;
using MediatR;

namespace Helios.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password):IRequest<ErrorOr<AuthenticationResult>>;