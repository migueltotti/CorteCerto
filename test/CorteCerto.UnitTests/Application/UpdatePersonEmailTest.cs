using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorteCerto.UnitTests.Application;

public class UpdatePersonEmailTest
{
    private ServiceProvider provider;
    private readonly UpdatePersonEmailCommandHandler commandHandler;

    public UpdatePersonEmailTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddLogging();
        services.AddMapster();
        services.AddScoped<IValidator<UpdatePersonEmailCommand>, UpdatePersonEmailValidator>();

        provider = services.BuildServiceProvider();

        commandHandler = new UpdatePersonEmailCommandHandler(
            provider.GetRequiredService<IPersonRepository>(),
            provider.GetRequiredService<IValidator<UpdatePersonEmailCommand>>(),
            provider.GetRequiredService<ILogger<UpdatePersonEmailCommandHandler>>()
        );
    }

    [Fact]
    public async Task UpdatePersonEmail_WithInvalidEmail_ShoulFail()
    {
        // Arrange
        var command = new UpdatePersonEmailCommand(
            PersonId: Guid.NewGuid(),
            CurrentEmail: "testeemail.con",
            NewEmail: "tesad"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("PersonError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task UpdatePersonEmail_WithInvalidPersonId_ShoulFail()
    {
        // Arrange
        var command = new UpdatePersonEmailCommand(
            PersonId: Guid.NewGuid(),
            CurrentEmail: "teste1@email.com",
            NewEmail: "teste2@email.com"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(PersonErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task UpdatePersonEmail_WithCurrentEmailMismatch_ShoulFail()
    {
        // Arrange
        var command = new UpdatePersonEmailCommand(
            PersonId: Guid.Parse("68f415b9-f9e8-489d-949f-28d2e0077e6a"),
            CurrentEmail: "teste1@email.com",
            NewEmail: "teste2@email.com"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(PersonErrors.EmailMismatch, result.Error);
    }

    [Fact]
    public async Task UpdatePersonEmail_WithValidArguments_ShoulBeSuccess()
    {
        // Arrange
        var command = new UpdatePersonEmailCommand(
            PersonId: Guid.Parse("68f415b9-f9e8-489d-949f-28d2e0077e6a"),
            CurrentEmail: "teste@silva.com",
            NewEmail: "testeAlterado@email.com"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.True(result.Data);
    }
}
