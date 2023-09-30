using Helios.Application.Common.Interfaces.Authentication;
using Helios.Application.Common.Interfaces.Persistence;
using Helios.Application.Common.Interfaces.Services;
using Helios.Infrastructure.Authentication;
using Helios.Infrastructure.Persistence;
using Helios.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Helios.Infrastructure;

public static class DependencyInjection
{
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfigurationManager  configuration) 
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator,JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        services.AddScoped<IUserRepsitory,UserRepository>();
        
        return services;
    }
}