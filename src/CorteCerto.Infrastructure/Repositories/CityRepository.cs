using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class CityRepository(CorteCertoDbContext context) :
    BaseRepository<City, int>(context),
    ICityRepository
{
    public async Task<City?> GetCityByNameAndStateAcronym(string cityName, string stateAcronym)
    {   
        var city = await context.Cities
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name == cityName && c.State.Acronym == stateAcronym);

        return city;
    }
}
