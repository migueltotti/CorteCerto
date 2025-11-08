using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CorteCerto.Application.UseCases.Commands;

public record RegisterServiceCommand(
    Guid BarberId,
    string Name,
    string Description,
    decimal Price,
    TimeSpan Duration
) : ICommand<Result<ServiceDto>>;
