using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Interfaces;

public interface IAddressService
{
    Task<Result<Address>> CreateAddressByCep(string cep, int number);
}
