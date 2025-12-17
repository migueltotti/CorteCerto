using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Requests;
using CorteCerto.Domain.Enums;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.Application.UseCases.Queries.People;

public record GetAppointmentsQuery(GetAppointmentsRequest Request) : IQuery<PagedResult<AppointmentDto>>;
