using System;

namespace Edutech.Api.Application;

public static class DependencyInjection
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<AuthSenticationService>();
    }
}
