using Helios.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Helios.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<AuthenticationService,AuthenticationService>();
        return services;
    }

} 