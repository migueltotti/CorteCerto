using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class StateRepository(CorteCertoDbContext context) :
    BaseRepository<State, int>(context),
    IStateRepository
{
    public async Task<State?> GeyStateByAcronym(string stateAcronym)
    {
        var state = await context.States
            .FirstOrDefaultAsync(s => s.Acronym == stateAcronym);

        return state;
    }
}
