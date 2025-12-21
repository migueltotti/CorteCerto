
using CorteCerto.Application.Requests;
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

public class UpsertBarberAvailabilityTest
{
    private readonly ServiceProvider provider;
    private readonly UpsertBarberAvailabilityCommandHandler commandHandler;

    public UpsertBarberAvailabilityTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<IValidator<UpsertBarberAvailabilityCommand>, UpsertBarberAvailabilityValidator>();
        services.AddLogging();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        commandHandler = new UpsertBarberAvailabilityCommandHandler(
            provider.GetRequiredService<IBarberRepository>(),
            provider.GetRequiredService<IValidator<UpsertBarberAvailabilityCommand>>(),
            provider.GetRequiredService<ILogger<UpsertBarberAvailabilityCommandHandler>>());
    }

    [Fact]
    public async Task UpsertBarberAvailability_WithInvalidBarberId_ShouldFail()
    {
        // Arrange
        var command = new UpsertBarberAvailabilityCommand(
            new UpsertBarberAvailabilityRequest(
                Guid.Parse("c160437f-405c-4203-824f-033b827a08cc"),
                DayOfWeek.Monday,
                DateTime.Parse("07:00:00-03:00"),
                DateTime.Parse("19:00:00-03:00")
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task UpsertBarberAvailability_WithEndTimeGreaterThanStartTime_ShouldFail()
    {
        // Arrange
        var command = new UpsertBarberAvailabilityCommand(
            new UpsertBarberAvailabilityRequest(
                Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                DayOfWeek.Monday,
                DateTime.Parse("10:00:00-03:00"),
                DateTime.Parse("7:00:00-03:00")
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("BarberAvailabilityError.InvalidTimeRange", result.Error.Code);
    }

    [Fact]
    public async Task UpsertBarberAvailability_WithValidArguments_ShouldBeSuccessAndAddMondayAvailability()
    {
        // Arrange
        var command = new UpsertBarberAvailabilityCommand(
            new UpsertBarberAvailabilityRequest(
                Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                DayOfWeek.Monday,
                DateTime.Parse("08:00:00-03:00"),
                DateTime.Parse("22:00:00-03:00")
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotEmpty(result.Data.Availabilities);
    }
    [Fact]
    public async Task UpsertBarberAvailability_WithValidArguments_ShouldBeSuccessAndUpdateMondayAvailability()
    {
        // Arrange
        var command = new UpsertBarberAvailabilityCommand(
            new UpsertBarberAvailabilityRequest(
                Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                DayOfWeek.Monday,
                DateTime.Parse("09:00:00-03:00"),
                DateTime.Parse("17:00:00-03:00")
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotEmpty(result.Data.Availabilities);
    }

}
