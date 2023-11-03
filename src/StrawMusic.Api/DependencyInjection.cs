using StrawMusic.Api.Common.Mapping;
using StrawMusic.Api.Common.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace StrawMusic.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {   services.AddControllers();
        services.AddSingleton<ProblemDetailsFactory,StrawMusicProblemDetailsFactory>();
        services.AddMappings();
        return services;
    }
}