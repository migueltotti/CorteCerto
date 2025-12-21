using System.Text.Json.Serialization;

namespace CorteCerto.Application.Requests;

public record UpsertBarberAvailabilityRequest(
    Guid BarberId,
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    DayOfWeek DayOfWeek,
    DateTime StartTime,
    DateTime EndTime
);