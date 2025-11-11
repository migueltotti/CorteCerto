using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
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

public class UpdateBarberProfileTest
{

    private ServiceProvider provider;
    private readonly UpdateBarberProfileCommandHandler commandHandler;

    public UpdateBarberProfileTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>();
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddLogging();
        services.AddMapster();
        services.AddScoped<IValidator<UpdateBarberProfileCommand>, UpdateBarberProfileValidator>();

        provider = services.BuildServiceProvider();

        commandHandler = new UpdateBarberProfileCommandHandler(
            provider.GetRequiredService<IBarberRepository>(),
            provider.GetRequiredService<IValidator<UpdateBarberProfileCommand>>(),
            provider.GetRequiredService<ILogger<UpdateBarberProfileCommandHandler>>()
        );
    }

    [Fact]
    public async Task UpdateBarberProfile_WithInvalidInfo_ShouldFail()
    {
        // Arrange
        var command = new UpdateBarberProfileCommand(
            Guid.NewGuid(),
            "te",
            "",
            "",
            "1231231231231312"
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("BarberError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task UpdateBarberProfile_WithInvalidBarberId_ShouldFail()
    {
        // Arrange
        var command = new UpdateBarberProfileCommand(
            Guid.NewGuid(),
            "teste",
            "wdadawdadawda",
            "awdadadwa",
            "18999999999"
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task UpdateBarberProfile_WithValidArguments_ShouldBeSuccess()
    {
        // Arrange
        var command = new UpdateBarberProfileCommand(
            Guid.Parse("fceceaf7-2d08-44f7-8752-a5b39ba820ed"),
            "Teste da Silva Alterado",
            "Descrição do Teste da Silva Alterado",
            "https://testeDaSilvaAlterado.com",
            "18991234768"
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(command.BarberId, result.Data.Id);
        Assert.Equal(command.Name, result.Data.Name);
        Assert.Equal(command.Description, result.Data.Description);
        Assert.Equal(command.PhoneNumber, result.Data.PhoneNumber);
    }
}
