using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class CountryRepository(CorteCertoDbContext context) : 
    BaseRepository<Country, int>(context), 
    ICountryRepository
{
}
