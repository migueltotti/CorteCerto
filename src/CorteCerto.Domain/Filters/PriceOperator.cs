using System.Text.Json.Serialization;

namespace CorteCerto.Domain.Filters;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PriceOperator
{
    Equal,
    GreaterThan,
    LessThan,
}
