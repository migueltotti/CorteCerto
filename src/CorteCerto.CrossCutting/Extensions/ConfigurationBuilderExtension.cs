using CorteCerto.CrossCutting.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace CorteCerto.CrossCutting.Extensions;

public static class ConfigurationBuilderExtension
{
    public static Settings GetApplicationSettings(this IConfiguration configuration, IHostEnvironment env)
	{
		var settings = configuration.GetSection("Settings").Get<Settings>();

		if (!env.IsDevelopment())
		{
			settings!.PostgresSettings.ConnectionString = GetEnvironmentVariableValue("PostgreSql_ConnectionString", settings.PostgresSettings.ConnectionString);
			settings.JwtSettings.SecretKey = GetEnvironmentVariableValue("Jwt_SecretKey", settings.JwtSettings.SecretKey);
			settings.HangfireSettings.DatabaseConnectionString = GetEnvironmentVariableValue("Hangfire_ConnectionString", settings.HangfireSettings.DatabaseConnectionString);
		}

		return settings!;
	}

	private static string GetEnvironmentVariableValue(string key, string? fallback)
	{
		var value = Environment.GetEnvironmentVariable(key);
		return string.IsNullOrWhiteSpace(value) ? fallback ?? "" : value;
	}
}