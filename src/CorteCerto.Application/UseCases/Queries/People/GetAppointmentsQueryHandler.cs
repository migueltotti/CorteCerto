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
            .WithAppointmentIds(query.Request.Ids)
            .WithCustomerId(query.Request.CustomerId)
            .WithBarberId(query.Request.BarberId)
            .WithServiceId(query.Request.ServiceId)
            .WithCustomerName(query.Request.CustomerName)
            .WithBarberName(query.Request.BarberName)
            .WithServiceName(query.Request.ServiceName)
            .WithAppointmentStatus(query.Request.AppointmentStatus)
            .WithDate(query.Request.InitialDate, query.Request.FinalDate)
            .WithPagination(query.Request.PageSize, query.Request.PageNumber)
            .Build();

        var appointments = await appointmentRepository.GetWithFilter(filter, ["Barber.Address.City.State.Country", "Customer", "Service"], cancellationToken);

        var paginatedResponse = appointments.Results.Adapt<List<AppointmentDto>>();

        return paginatedResponse.ToPagedResult(appointments.TotalCount, appointments.PageSize, appointments.PageNumber);
    }
}
