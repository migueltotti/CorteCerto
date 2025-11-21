using CorteCerto.Application.Common;
using CorteCerto.Application.DTO;
using CorteCerto.Application.Extentions;
using CorteCerto.Domain.Filters;
using CorteCerto.Domain.Interfaces.Repositories;
using LiteBus.Queries.Abstractions;
using Mapster;

namespace CorteCerto.Application.UseCases.Queries.People;

public class GetAppointmentsQueryHandler(
    IAppointmentRepository appointmentRepository) : IQueryHandler<GetAppointmentsQuery, PagedResult<AppointmentDto>>
{
    public async Task<PagedResult<AppointmentDto>> HandleAsync(GetAppointmentsQuery query, CancellationToken cancellationToken = default)
    {
        var filter = new AppointmentFilter.Builder()
            .WithAppointmentId(query.Id)
            .WithCustomerId(query.CustomerId)
            .WithBarberId(query.BarberId)
            .WithServiceId(query.ServiceId)
            .WithCustomerName(query.CustomerName)
            .WithBarberName(query.BarberName)
            .WithServiceName(query.ServiceName)
            .WithAppointmentStatus(query.AppointmentStatus)
            .WithDate(query.InitialDate, query.FinalDate)
            .WithPagination(query.PageSize, query.PageNumber)
            .Build();

        var appointments = await appointmentRepository.GetWithFilter(filter, ["Barber", "Customer", "Service"], cancellationToken);

        var paginatedResponse = appointments.Results.Adapt<List<AppointmentDto>>();

        return paginatedResponse.ToPagedResult(appointments.TotalCount, appointments.PageSize, appointments.PageNumber);
    }
}
