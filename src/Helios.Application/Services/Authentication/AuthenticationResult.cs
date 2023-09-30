using Helios.Domain.User;

namespace Helios.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);