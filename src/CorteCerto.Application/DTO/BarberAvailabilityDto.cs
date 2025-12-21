using System.Text.Json.Serialization;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Application.DTO;

public record BarberAvailabilityDto(
    [property: JsonConverter(typeof(JsonStringEnumConverter))]
    DayOfWeek DayOfWeek,
    TimeOnly StartTime,
    TimeOnly EndTime
);