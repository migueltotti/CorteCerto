using CorteCerto.Infrastructure.Factories;
using CorteCerto.Infrastructure.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CorteCerto.CrossCutting.Extensions;

public static class SmtpExtension
{
    public static IServiceCollection ConfigureSmtpClient(this IServiceCollection services, SmtpClientSettings settings)
    {
        services.AddSingleton<IOptions<SmtpClientSettings>>(Options.Create(settings));

        services.AddTransient<ISmtpClientFactory, SmtpClientFactory>();
        
        return services;
    }
}