namespace CorteCerto.App.Models;

internal class ValidationErrorModel
{
    public string? PropertyName { get; set; }
    public string? ErrorMessage { get; set; }
    public string? AttemptedValue { get; set; }
    public string? CustomState { get; set; }
    public int Severity { get; set; }
    public string? ErrorCode { get; set; }
    public Dictionary<string, object>? FormattedMessagePlaceholderValues { get; set; }
}
