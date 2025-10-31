using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IStateRepository : IBaseRepository<State>
{
    Task<State?> GeyStateByAcronym(string stateAcronym);
}
