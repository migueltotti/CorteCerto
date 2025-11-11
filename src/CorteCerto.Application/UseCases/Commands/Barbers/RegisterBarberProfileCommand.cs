using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record RegisterBarberProfileCommand(
    Guid PersonId, 
    string Description, 
    string? PortfolioUrl,
    string Cep, 
    int AddressNumber
) : ICommand<Result<BarberDto>>;
