using CorteCerto.CrossCutting.Models;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorteCerto.CrossCutting.Extensions;

public static class DatabaseExtension
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, PostgresSettings postgresSettings)
    {
        services.AddDbContext<CorteCertoDbContext>(config =>
        {
            config.UseNpgsql(postgresSettings.ConnectionString);
        });
        
        return services;
    }
}