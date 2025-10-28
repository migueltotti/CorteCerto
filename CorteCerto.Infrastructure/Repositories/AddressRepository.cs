using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class AddressRepository(CorteCertoDbContext context) :
    BaseRepository<Address, Guid>(context),
    IAddressRepository
{
}
