using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Enums;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.People;

public record GetAppointmentsQuery(
    Guid? Id = null,
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
) : IQuery<PagedResult<AppointmentDto>>;
