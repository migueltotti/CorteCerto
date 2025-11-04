using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using LiteBus.Commands.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Application.UseCases.Commands;

public record RegisterBarberProfileCommand(
    Guid PersonId, 
    string Description, 
    string? PortfolioUrl,
    string Cep, 
    int AddressNumber
) : ICommand<Result<BarberDto>>;
