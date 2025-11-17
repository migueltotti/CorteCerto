using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CorteCerto.Infrastructure.Repositories;

public class CountryRepository(CorteCertoDbContext context) :
    BaseRepository<Country, int>(context),
    ICountryRepository
{
    public async Task<Country?> GetCountryByName(string name)
    {
        var country = await context.Countries
            .AsNoTracking()
            .FirstOrDefaultAsync(c => c.Name == name);

        return country;
    }
}
