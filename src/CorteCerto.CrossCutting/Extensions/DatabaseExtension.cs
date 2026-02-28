using CorteCerto.CrossCutting.Models;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class DatabaseExtension
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, PostgresSettings postgresSettings)
    {
        services.AddDbContext<CorteCertoDbContext>(config =>
        {
            config.UseNpgsql(postgresSettings.ConnectionString);
            config.EnableSensitiveDataLogging();
        });
        
        return services;
    }
}