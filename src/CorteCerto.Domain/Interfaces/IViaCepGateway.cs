using CorteCerto.Domain.Base;
using CorteCerto.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Interfaces;

public interface IViaCepGateway
{
    Task<Result<AddressLookupResult>> GetAddressByZipCodeAsync(string zipCode);
}
