using CorteCerto.Domain.Base;
using CorteCerto.Domain.Responses;

namespace CorteCerto.Domain.Interfaces.Gateways;

public interface IViaCepClient
{
    Task<Result<AddressLookupResult>> GetAddressByCepAsync(string zipCode);
}
