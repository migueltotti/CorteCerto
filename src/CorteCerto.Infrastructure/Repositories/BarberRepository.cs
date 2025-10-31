using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class BarberRepository(CorteCertoDbContext context) : 
    BaseRepository<Barber, Guid>(context), 
    IBarberRepository
{
    public async Task<bool> EmailExistsAsync(string email)
    {
        return await context.People.AnyAsync(c => c.Email == email);
    }
}
