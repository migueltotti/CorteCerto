using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Enums;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.People;

public record GetAppointmentsQuery(
    Guid? Id,
    Guid? CustomerId,
    Guid? BarberId,
    int? ServiceId,
    string? CustomerName,
    string? BarberName,
    string? ServiceName,
    AppointmentStatus? AppointmentStatus,
    DateTime? InitialDate,
    DateTime? FinalDate,
    int PageSize = 50,
    int PageNumber = 1
) : IQuery<PagedResult<AppointmentDto>>;
