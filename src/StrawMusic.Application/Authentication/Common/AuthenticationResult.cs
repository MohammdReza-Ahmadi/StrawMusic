using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Application.Authentication.Common;

public record AuthenticationResult(UserEntity User, string Token);