using System.Text.Json.Serialization;

namespace CorteCerto.Domain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AppointmentStatus
{
    WaitingForAprovement,
    Scheduled,
    Completed,
    Canceled
}