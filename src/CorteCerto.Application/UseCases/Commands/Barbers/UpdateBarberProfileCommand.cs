using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.Barbers;

public record UpdateBarberProfileCommand(
    Guid BarberId, 
    string Name,
    string Description,
    string? PortfolioUrl,
    string PhoneNumber,
    string Cep,
    int AddressNumber
) : ICommand<Result<BarberDto>>;
