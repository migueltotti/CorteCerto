using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.Application.UseCases.Commands.People;

public record UpdateProfileInfoCommand(
    Guid PersonId,
    string NewName,
    string NewPhoneNumber
) : ICommand<Result<CustomerDto>>;