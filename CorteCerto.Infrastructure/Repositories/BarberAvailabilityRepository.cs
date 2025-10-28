using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class BarberAvailabilityRepository(CorteCertoDbContext context) : 
    BaseRepository<BarberAvailability, int>(context), 
    IBarberAvailabilityRepository
{
}
