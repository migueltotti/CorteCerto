using CorteCerto.Infrastructure.Authentication;

namespace CorteCerto.CrossCutting.Models;

public interface ISettings
{
    public PostgresSettings PostgresSettings { get; }
    public JwtSettings JwtSettings { get; }
}

public class Settings : ISettings
{
    public PostgresSettings PostgresSettings { get; set; }
    public JwtSettings JwtSettings { get; set; }
}