using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorteCerto.UnitTests.Application;

public class CancelAppointmentTest
{
    private readonly ServiceProvider provider;
    private readonly CancelAppointmentCommandHandler commandHandler;

    public CancelAppointmentTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<IValidator<CancelAppointmentCommand>, CancelAppointmentValidator>();
        services.AddLogging();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        commandHandler = new CancelAppointmentCommandHandler(
            provider.GetRequiredService<IAppointmentRepository>(),
            provider.GetRequiredService<IValidator<CancelAppointmentCommand>>(),
            provider.GetRequiredService<ILogger<CancelAppointmentCommandHandler>>());
    }

    [Fact]
    public async Task CancelAppointment_WithIncorrectAppointmentId_ShouldFail()
    {
        // Arrange
        var command = new CancelAppointmentCommand(
            Guid.NewGuid(),
            Guid.NewGuid()
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task CancelAppointment_WithIncorrectBarberId_ShouldFail()
    {
        // Arrange
        var command = new CancelAppointmentCommand(
            Guid.Parse("ff410b56-fa74-409a-8c8e-f0f94885f1d5"),
            Guid.NewGuid()
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.BarberIdMismatch, result.Error);
    }

    [Fact]
    public async Task CancelAppointment_WithIncorrectAppointmentStatus_ShouldFail()
    {
        // Arrange
        var command = new CancelAppointmentCommand(
            Guid.Parse("b38fa14d-d01e-4ed6-b850-a4a2695c6962"),
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c")
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.CancelationFailed, result.Error);
    }

    [Fact]
    public async Task CancelAppointment_WithValidArguments_ShouldCancelAppointmentWithSuccess()
    {
        // Arrange
        var command = new CancelAppointmentCommand(
            Guid.Parse("4e14d509-25e0-453b-8d96-7a717c39aed6"),
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c")
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(Guid.Parse("4e14d509-25e0-453b-8d96-7a717c39aed6"), result.Data.Id);
        Assert.Equal(Guid.Parse("c160437f-405c-4203-824f-033b827a089c"), result.Data.Barber.Id);
        Assert.Equal(AppointmentStatus.Canceled, result.Data.Status);
    }
}
