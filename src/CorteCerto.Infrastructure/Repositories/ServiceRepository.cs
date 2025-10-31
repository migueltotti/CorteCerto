using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class ServiceRepository(CorteCertoDbContext context) : 
    BaseRepository<Service, int>(context), 
    IServiceRepository
{
}
