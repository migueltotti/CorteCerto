using CorteCerto.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CorteCerto.CrossCutting.Extensions;

public static class JwtExtension
{
    public static IServiceCollection AddJwtSettings(this IServiceCollection services, JwtSettings settings)
    {
        services.AddSingleton<IOptions<JwtSettings>>(Options.Create(settings));
        
        return services;
    }
}