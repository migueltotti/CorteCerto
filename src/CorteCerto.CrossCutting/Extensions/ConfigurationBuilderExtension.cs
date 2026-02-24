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
			settings.SmtpClientSettings.Host = GetEnvironmentVariableValue("Smtp_Host", settings.SmtpClientSettings.Host);
			settings.SmtpClientSettings.Port = int.Parse(GetEnvironmentVariableValue("Smtp_Port", settings.SmtpClientSettings.Port.ToString()));
			settings.SmtpClientSettings.Name = GetEnvironmentVariableValue("Smtp_Name", settings.SmtpClientSettings.Name);
			settings.SmtpClientSettings.Username = GetEnvironmentVariableValue("Smtp_Username", settings.SmtpClientSettings.Username);
			settings.SmtpClientSettings.Password = GetEnvironmentVariableValue("Smtp_Password", settings.SmtpClientSettings.Password);
		}

		return settings!;
	}

	private static string GetEnvironmentVariableValue(string key, string? fallback)
	{
		var value = Environment.GetEnvironmentVariable(key);
		return string.IsNullOrWhiteSpace(value) ? fallback ?? "" : value;
	}
}