using CorteCerto.Application.Common;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IAppointmentRepository : IBaseRepository<Appointment>
{
    Task<PagedResult<Appointment>> GetWithFilter(AppointmentFilter filter, List<string>? includes = null, CancellationToken token = default);
}
