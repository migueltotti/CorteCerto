using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record CreateAccountCommand(
    string Name,
    string Email,
    string Password,
    string PhoneNumber
) : ICommand<Result<CustomerDto>>;
