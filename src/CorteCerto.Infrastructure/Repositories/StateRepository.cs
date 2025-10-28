using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Interfaces;
using CorteCerto.Infrastructure.Context;
using System;

namespace CorteCerto.Infrastructure.Repositories;

public class StateRepository(CorteCertoDbContext context) : 
    BaseRepository<State, int>(context), 
    IStateRepository
{
}
