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

    public async Task<Barber> RegisterBarber(Barber barber)
    {
        var result = await context.Database.ExecuteSqlInterpolatedAsync(
            $@"
            INSERT INTO public.""Barbers""(
                ""Id"",
                ""Description"",
                ""PortfolioUrl"",
                ""Rating"",
                ""AddressId"")
            VALUES(
                {barber.Id},
                {barber.Description},
                {barber.PortfolioUrl},
                {barber.Rating},
                {barber.Address.Id});"
        );

        if(result == 0)
            throw new Exception("Failed to register barber.");

        return barber;
    }
}
