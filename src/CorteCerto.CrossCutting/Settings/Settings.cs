

namespace CorteCerto.CrossCutting.Settings;

public class Settings : ISettings
{
    public required JwtSettings JwtSettings { get; set; }
}
