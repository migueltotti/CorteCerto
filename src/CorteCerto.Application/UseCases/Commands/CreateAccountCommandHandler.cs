using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using System.Text.Json;

namespace CorteCerto.Application.UseCases.Commands;

public class CreateAccountCommandHandler(
    ICustomerRepository customerRepository,
    IValidator<CreateAccountCommand> validator,
    IPasswordHashService hashService) 
    : ICommandHandler<CreateAccountCommand, Result<CustomerDto>>
{
    public async Task<Result<CustomerDto>> HandleAsync(CreateAccountCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command, cancellationToken);

        if(!validationResult.IsValid)
            return Result<CustomerDto>.Failure(CustomerErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));

        var emailExists = await customerRepository.EmailExistsAsync(command.Email);

        if(emailExists)
            return Result<CustomerDto>.Failure(CustomerErrors.DuplicateEmail);

        var hashedPassword = hashService.Hash(command.Password);

        var newCustomer = new Customer(
            Guid.NewGuid(),
            command.Name,
            command.Email,
            command.PhoneNumber,
            hashedPassword
        );

        customerRepository.Insert(newCustomer);

        var customerResult = new CustomerDto(
            newCustomer.Id,
            newCustomer.Name,
            newCustomer.Email,
            newCustomer.PhoneNumber,
            newCustomer.PromotionPoints
        );

        return Result<CustomerDto>.Success(customerResult);
    }
}
