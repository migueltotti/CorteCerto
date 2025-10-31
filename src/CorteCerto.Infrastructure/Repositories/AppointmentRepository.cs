using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class AppointmentRepository(CorteCertoDbContext context) : 
    BaseRepository<Appointment, Guid>(context),
    IAppointmentRepository
{
}
