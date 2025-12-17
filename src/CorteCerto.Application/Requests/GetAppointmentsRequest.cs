using CorteCerto.Domain.Enums;

namespace CorteCerto.Application.Requests;

public record GetAppointmentsRequest(
    IEnumerable<Guid>? Ids = null,
    Guid? CustomerId = null,
    Guid? BarberId = null,
    int? ServiceId = null,
    string? CustomerName = null,
    string? BarberName = null,
    string? ServiceName = null,
    AppointmentStatus? AppointmentStatus = null,
    DateTime? InitialDate = null,
    DateTime? FinalDate = null,
    int PageSize = 50,
    int PageNumber = 1    
);