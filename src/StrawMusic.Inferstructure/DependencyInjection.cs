using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.Common.Interfaces.Services;
using StrawMusic.Infrastructure.Persistence;
using StrawMusic.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace StrawMusic.Infrastructure;

public static class DependencyInjection
{
     public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration) 
    {


        services.AddAuth(configuration);

        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        
        return services;
    }

    public static IServiceCollection AddAuth(this IServiceCollection services, ConfigurationManager configuration)
    {


        services.AddSingleton<IMusicRepository, MusicRepository>();

        return services;
    }


}