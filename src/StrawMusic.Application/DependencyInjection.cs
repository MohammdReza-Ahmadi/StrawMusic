using System.Reflection;
using FluentValidation;
using StrawMusic.Application.Common.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using StrawMusic.Application.Music.AddMusics;
using StrawMusic.Application.Music.GetMusics;
using StrawMusic.Application.Music.DeleteMusics;

namespace StrawMusic.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddScoped<IUploadMusic,UploadMusic>();

        services.AddScoped<IGetMusicsService, GetMusicsService>();

        services.AddScoped<IDeleteMusic, DeleteMusic>();

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }

} 