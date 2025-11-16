using CorteCerto.Domain.Base;
using CorteCerto.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Interfaces.Repositories;

public interface IViaCepGateway
{
    Task<Result<AddressLookupResult>> GetAddressByCepAsync(string zipCode);
}
