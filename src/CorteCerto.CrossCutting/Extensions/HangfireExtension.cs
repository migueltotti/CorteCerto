using CorteCerto.CrossCutting.Models;
using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class HangfireExtension
{
    public static IServiceCollection ConfigureHangfire(this IServiceCollection services, HangfireSettings settings)
    {
        services.AddHangfire(config => config
            .SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
            .UseSimpleAssemblyNameTypeSerializer()
            .UseRecommendedSerializerSettings()
            .UsePostgreSqlStorage(c => c
                .UseNpgsqlConnection(settings.DatabaseConnectionString)));
        
        services.AddHangfireServer();

        services.AddMvc();
        
        return services;
    }
}