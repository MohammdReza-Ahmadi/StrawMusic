using ErrorOr;
using Helios.Application.Authentication.Common;
using MediatR;

namespace Helios.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
):IRequest<ErrorOr<AuthenticationResult>>;