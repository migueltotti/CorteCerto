using CorteCerto.App.Interfaces;
using CorteCerto.App.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App.Infra;

internal static class NavegationServiceConfiguration
{
    public static IServiceCollection AddNavegationService(this IServiceCollection services, Action<NavegationService.Builder> action)
    {
        var navegationServiceBuilder = new NavegationService.Builder();

        action(navegationServiceBuilder);

        services.AddSingleton<INavegationService, NavegationService>(s =>
        {
            return navegationServiceBuilder.Build(s.GetRequiredService<ISessionService>());
        });

        return services;
    }
}
