using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class AddressRepository(CorteCertoDbContext context) :
    BaseRepository<Address, Guid>(context),
    IAddressRepository
{
    public async Task<Address?> GetAddressByZipCode(string zipCode)
    {
        var address = await context.Addresses
            .FirstOrDefaultAsync(a => a.ZipCode == zipCode);

        return address;
    }
}
