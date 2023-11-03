using ErrorOr;
using StrawMusic.Application.Authentication.Common;
using MediatR;

namespace StrawMusic.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
):IRequest<ErrorOr<AuthenticationResult>>;