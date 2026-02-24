using CorteCerto.Infrastructure.Authentication;
using CorteCerto.Infrastructure.Models;

namespace CorteCerto.CrossCutting.Models;

public interface ISettings
{
    public PostgresSettings PostgresSettings { get; }
    public JwtSettings JwtSettings { get; }
    public HangfireSettings HangfireSettings { get; }
    public SmtpClientSettings SmtpClientSettings { get; }
}

public class Settings : ISettings
{
    public required PostgresSettings PostgresSettings { get; init; }
    public required JwtSettings JwtSettings { get; init; }
    public required HangfireSettings HangfireSettings { get; init; }
    public required SmtpClientSettings SmtpClientSettings { get; init; }
}