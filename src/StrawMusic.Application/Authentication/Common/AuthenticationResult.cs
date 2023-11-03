using Helios.Domain.User;

namespace Helios.Application.Authentication.Common;

public record AuthenticationResult(User User, string Token);