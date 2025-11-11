using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Application;

public class UpdatePersonPasswordTest
{
    private ServiceProvider provider;
    private readonly UpdatePersonPasswordCommandHandler commandHandler;

    public UpdatePersonPasswordTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddLogging();
        services.AddMapster();
        services.AddScoped<IValidator<UpdatePersonPasswordCommand>, UpdatePersonPasswordValidator>();

        provider = services.BuildServiceProvider();

        commandHandler = new UpdatePersonPasswordCommandHandler(
            provider.GetRequiredService<IPersonRepository>(),
            provider.GetRequiredService<IValidator<UpdatePersonPasswordCommand>>(),
            provider.GetRequiredService<IPasswordHashService>(),
            provider.GetRequiredService<ILogger<UpdatePersonPasswordCommandHandler>>()
        );
    }

    [Fact]
    public async Task UpdatePersonPassword_WithInvalidPassword_ShoulFail()
    {
        // Arrange
        var command = new UpdatePersonPasswordCommand(
            PersonId: Guid.NewGuid(),
            CurrentPassword: "testee",
            NewPassword: "tesad"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("PersonError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task UpdatePersonPassword_WithInvalidPersonId_ShoulFail()
    {
        // Arrange
        var command = new UpdatePersonPasswordCommand(
            PersonId: Guid.NewGuid(),
            CurrentPassword: "TesteSenha123@",
            NewPassword: "TesteSenha123##"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(PersonErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task UpdatePersonPassword_WithCurrentPasswordMismatch_ShoulFail()
    {
        // Arrange
        var command = new UpdatePersonPasswordCommand(
            PersonId: Guid.Parse("6bad02d7-b8bf-41bd-bb05-0f58369facf1"),
            CurrentPassword: "TesteSenha123@",
            NewPassword: "TesteSenha123##"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(PersonErrors.PasswordMismatch, result.Error);
    }

    [Fact]
    public async Task UpdatePersonPassword_WithValidArguments_ShoulBeSuccess() 
    {
        // Arrange
        var command = new UpdatePersonPasswordCommand(
            PersonId: Guid.Parse("6bad02d7-b8bf-41bd-bb05-0f58369facf1"),
            CurrentPassword: "Teste123@",
            NewPassword: "TesteSenha123##"
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.True(result.Data);
    }
}
