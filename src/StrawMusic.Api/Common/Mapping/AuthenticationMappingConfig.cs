using StrawMusic.Application.Authentication.Commands.Register;
using StrawMusic.Application.Authentication.Common;
using StrawMusic.Application.Authentication.Queries.Login;
using StrawMusic.Contracts.Authentication;
using Mapster;

namespace StrawMusic.Api.Common.Mapping;

public class AuthenticationMsppingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();

        config.NewConfig<LoginRequest, LoginQuery>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
        .Map(dest => dest, src =>src.User);
    }
}