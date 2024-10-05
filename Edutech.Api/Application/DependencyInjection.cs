using System;
using Edutech.Api.Application.Services;

namespace Edutech.Api.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<AuthSenticationService>();
        services.AddScoped<CourseService>();
        return services;
    }
}
