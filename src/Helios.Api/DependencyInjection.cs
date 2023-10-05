using Helios.Api.Common.Mapping;
using Helios.Api.Common.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Helios.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {   services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory,HeliosProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}