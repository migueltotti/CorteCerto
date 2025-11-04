using CorteCerto.Application.UseCases.Commands;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Application;

public class CreateAccountTest
{
    private readonly CorteCertoDbContext context;
    private readonly ICustomerRepository customerRepository;
    private readonly IValidator<CreateAccountCommand> validator;
    private readonly IPasswordHashService hashService;
    private readonly CreateAccountCommandHandler handler;

    public CreateAccountTest()
    {
        context = new CorteCertoDbContext();
        customerRepository = new CustomerRepository(context);
        validator = new CreateAccountCommandValidatior();
        hashService = new PasswordHashService();
        handler = new CreateAccountCommandHandler(customerRepository, validator, hashService);
    }

    [Fact]
    public async Task CreateAccount_WithValidAtributes_ShouldCreateAccountSuccessfully()
    {
        // Arrange
        var command = new CreateAccountCommand(
            "Teste da Silva",
            "teste2@silva",
            "Teste123@",
            "18997872005"
        );

        // Act
        var result = await handler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal("Teste da Silva", result.Data.Name);
        Assert.Equal("teste2@silva", result.Data.Email);
        Assert.Equal("18997872005", result.Data.PhoneNumber);
        Assert.Equal(0, result.Data.PromotionPoints);
    }
}