using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorteCerto.UnitTests.Application;

public class UpdateServiceTest
{
    private readonly ServiceProvider provider;
    private readonly UpdateServiceCommandHandler commandHandler;

    public UpdateServiceTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<IValidator<UpdateServiceCommand>, UpdateServiceValidator>();
        services.AddLogging();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        commandHandler = new UpdateServiceCommandHandler(
            provider.GetRequiredService<IBarberRepository>(),
            provider.GetRequiredService<IValidator<UpdateServiceCommand>>(),
            provider.GetRequiredService<ILogger<UpdateServiceCommandHandler>>());
    }

    [Fact]
    public async Task UpdateService_WithInvalidArguments_ShouldFail()
    {
        // Arrange
        var command = new UpdateServiceCommand(
            Guid.NewGuid(),
            1,
            "",
            "",
            10,
            TimeSpan.FromSeconds(0),
            false
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("BarberError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task UpdateService_WithIncorrectBarberId_ShouldFail()
    {
        // Arrange
        var command = new UpdateServiceCommand(
            Guid.NewGuid(),
            1,
            "Teste barberio não encontrado",
            "Teste barberio não encontrado",
            10,
            TimeSpan.FromMinutes(25),
            false
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task UpdateService_WithIncorrectServiceId_ShouldFail()
    {
        // Arrange
        var command = new UpdateServiceCommand(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            999,
            "Teste serviço não encontrado",
            "Teste serviço não encontrado",
            10,
            TimeSpan.FromMinutes(25),
            false
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.ServiceNotFound, result.Error);
    }

    [Fact]
    public async Task UpdateService_WithValidService_ShouldReturnUpdatedService()
    {
        // Arrange
        var command = new UpdateServiceCommand(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            1,
            "Teste serviço alterado",
            "Teste serviço alterado",
            500,
            TimeSpan.FromMinutes(30),
            false
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(command.ServiceId, result.Data.Id);
        Assert.Equal(command.Name, result.Data.Name);
        Assert.Equal(command.Description, result.Data.Description);
        Assert.Equal(command.Price, result.Data.Price);
        Assert.Equal(command.Duration, result.Data.Duration);
        Assert.Equal(command.IsAvailable, result.Data.IsAvailable);
    }
}
