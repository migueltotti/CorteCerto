using CorteCerto.Domain.Base;
using CorteCerto.Domain.Responses;

namespace CorteCerto.Domain.Interfaces.Gateways;

public interface IViaCepGateway
{
    Task<Result<AddressLookupResult>> GetAddressByCepAsync(string zipCode);
}
