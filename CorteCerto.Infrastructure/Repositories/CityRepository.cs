using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class CityRepository(CorteCertoDbContext context) : 
    BaseRepository<City, int>(context), 
    ICityRepository
{
}
