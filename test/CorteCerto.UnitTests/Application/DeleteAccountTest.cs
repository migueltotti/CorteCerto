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
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Application;

public class DeleteAccountTest
{
    private readonly ServiceProvider provider;
    private readonly DeleteAccountCommandHandler commandHandler;

    public DeleteAccountTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IValidator<DeleteAccountCommand>, DeleteAccountValidator>();
        services.AddLogging();

        provider = services.BuildServiceProvider();

        commandHandler = new DeleteAccountCommandHandler(
            provider.GetRequiredService<IPersonRepository>(),
            provider.GetRequiredService<IValidator<DeleteAccountCommand>>(),
            provider.GetRequiredService<ILogger<DeleteAccountCommandHandler>>());
    }

    [Fact]
    public async Task DeleteAccount_WithIncorrectId_ShouldFail()
    {
        // Arrange
        var command = new DeleteAccountCommand(
            Guid.NewGuid()    
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(PersonErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task DeleteAccount_WithValidPersonId_ShouldDeleteSuccessfully()
    {
        // Arrange
        var command = new DeleteAccountCommand(
            Guid.Parse("68f415b9-f9e8-489d-949f-28d2e0077e6a")
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
    }
}
