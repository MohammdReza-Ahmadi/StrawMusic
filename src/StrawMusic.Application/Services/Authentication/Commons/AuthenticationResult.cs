using StrawMusic.Domain.UserEntity;

namespace StrawMusic.Application.Services.Authentication;

public record AuthenticationResult(
    UserEntity User,
    string Token
);