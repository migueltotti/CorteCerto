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

public class DeleteServiceTest
{
    private readonly ServiceProvider provider;
    private readonly DeleteServiceCommandHandler commandHandler;

    public DeleteServiceTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<IValidator<DeleteServiceCommand>, DeleteServiceValidator>();
        services.AddLogging();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        commandHandler = new DeleteServiceCommandHandler(
            provider.GetRequiredService<IBarberRepository>(),
            provider.GetRequiredService<IValidator<DeleteServiceCommand>>(),
            provider.GetRequiredService<ILogger<DeleteServiceCommandHandler>>());
    }

    [Fact]
    public async Task DeleteService_WithInvalidArguments_ShouldFail()
    {
        // Arrange
        var command = new DeleteServiceCommand(
            Guid.NewGuid(),
            -1
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("BarberError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task DeleteService_WithIncorrectBarberId_ShouldFail()
    {
        // Arrange
        var command = new DeleteServiceCommand(
            Guid.NewGuid(),
            1
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task DeleteService_WithIncorrectServiceId_ShouldFail()
    {
        // Arrange
        var command = new DeleteServiceCommand(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            999
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.ServiceNotFound, result.Error);
    }

    [Fact]
    public async Task DeleteService_WithValidService_ShouldReturnUpdatedService()
    {
        // Arrange
        var command = new DeleteServiceCommand(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            10
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
    }
}
