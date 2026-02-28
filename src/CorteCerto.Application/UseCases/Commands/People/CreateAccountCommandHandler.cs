using CorteCerto.Application.DTO;
using CorteCerto.Domain.Base;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using FluentValidation;
using LiteBus.Commands.Abstractions;
using System.Text.Json;
using CorteCerto.Application.Interfaces;
using CorteCerto.Application.Requests;
using Mapster;
using Microsoft.Extensions.Logging;

namespace CorteCerto.Application.UseCases.Commands.People;

public class CreateAccountCommandHandler(
    ICustomerRepository customerRepository,
    IValidator<CreateAccountRequest> validator,
    IPasswordHashService hashService,
    IEmailService emailService,
    ILogger<CreateAccountCommandHandler> logger) 
    : ICommandHandler<CreateAccountCommand, Result<CustomerDto>>
{
    public async Task<Result<CustomerDto>> HandleAsync(CreateAccountCommand command, CancellationToken cancellationToken = default)
    {
        var validationResult = await validator.ValidateAsync(command.Request, cancellationToken);

        if (!validationResult.IsValid)
        {
            logger.LogInformation("Invalid data for creating account.");
            
            return Result<CustomerDto>.Failure(CustomerErrors.ValidationError(JsonSerializer.Serialize(validationResult.Errors)));
        }
            
        var emailExists = await customerRepository.EmailExistsAsync(command.Request.Email);

        if (emailExists)
        {
            logger.LogInformation("Email already registered for another account: {Email}", command.Request.Email);
            
            return Result<CustomerDto>.Failure(CustomerErrors.DuplicateEmail);
        }

        var hashedPassword = hashService.Hash(command.Request.Password);

        var newCustomer = new Customer(
            Guid.NewGuid(),
            command.Request.Name,
            command.Request.Email,
            command.Request.PhoneNumber,
            hashedPassword
        );

        customerRepository.Insert(newCustomer);

        await emailService.SendUserEmailConfirmationAsync(newCustomer, cancellationToken);
        
        logger.LogInformation("Account created successfully for email: {Email}", command.Request.Email);

        return Result<CustomerDto>.Success(newCustomer.Adapt<CustomerDto>());
    }
}
