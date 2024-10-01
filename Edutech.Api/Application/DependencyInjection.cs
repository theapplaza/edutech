using System;

namespace Edutech.Api.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<AuthSenticationService>();
        return services;
    }
}
