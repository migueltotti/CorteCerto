using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class BarberRepository(CorteCertoDbContext context) : 
    BaseRepository<Barber, Guid>(context), 
    IBarberRepository
{
}
