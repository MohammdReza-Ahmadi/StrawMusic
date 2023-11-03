using Helios.Application.Authentication.Commands.Register;
using Helios.Application.Authentication.Common;
using Helios.Application.Authentication.Queries.Login;
using Helios.Contracts.Authentication;
using Mapster;

namespace Helios.Api.Common.Mapping;

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