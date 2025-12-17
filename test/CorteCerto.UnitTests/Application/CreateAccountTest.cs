using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorteCerto.Application.Requests;
using Mapster;
using Microsoft.Extensions.Logging;

namespace CorteCerto.UnitTests.Application;

public class CreateAccountTest
{
    private readonly ServiceProvider provider;
    private readonly CreateAccountCommandHandler commandHandler;

    public CreateAccountTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IValidator<CreateAccountRequest>, CreateAccountValidator>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddMapster();
        services.AddLogging();

        provider = services.BuildServiceProvider();

        commandHandler = new CreateAccountCommandHandler(
            provider.GetRequiredService<ICustomerRepository>(),
            provider.GetRequiredService<IValidator<CreateAccountRequest>>(),
            provider.GetRequiredService<IPasswordHashService>(),
            provider.GetRequiredService<ILogger<CreateAccountCommandHandler>>());
    }


    [Fact]
    public async Task CreateAccount_WithInvalidAtributes_ShouldFail()
    {
        // Arrange
        var command = new CreateAccountCommand(
            new CreateAccountRequest(
                "Tes",
                "testeFalhoDaSilva",
                "Teste1231w23",
                "18997872005-1231"
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("CustomerError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task CreateAccount_WithDuplicateEmail_ShouldFail()
    {
        // Arrange
        var command = new CreateAccountCommand(
            new CreateAccountRequest(
                "Teste com email duplicado",
                "teste@silva.com",
                "Teste12@23",
                "18999999999"
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(CustomerErrors.DuplicateEmail, result.Error);
    }

    [Fact]
    public async Task CreateAccount_WithValidAtributes_ShouldCreateAccountSuccessfully()
    {
        // Arrange
        var command = new CreateAccountCommand(
            new CreateAccountRequest(
                "Teste da Silva",
                "teste4@silva",
                "Teste123@",
                "18997872005"
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal("Teste da Silva", result.Data.Name);
        Assert.Equal("teste4@silva", result.Data.Email);
        Assert.Equal("18997872005", result.Data.PhoneNumber);
        Assert.Equal(0, result.Data.PromotionPoints);
    }
}