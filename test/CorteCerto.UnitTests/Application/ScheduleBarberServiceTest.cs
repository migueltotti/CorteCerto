using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Application.UseCases.Commands.Customers;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorteCerto.Application.Requests;

namespace CorteCerto.UnitTests.Application;

public class ScheduleBarberServiceTest
{
    private readonly ServiceProvider provider;
    private readonly ScheduleBarberServiceCommandHandler commandHandler;

    public ScheduleBarberServiceTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddLogging();
        services.AddMapster();
        services.AddScoped<IValidator<ScheduleBarberServiceCommand>, ScheduleBarberServiceValidator>();

        provider = services.BuildServiceProvider();

        commandHandler = new ScheduleBarberServiceCommandHandler(
            provider.GetRequiredService<IBarberRepository>(),
            provider.GetRequiredService<ICustomerRepository>(),
            provider.GetRequiredService<IAppointmentRepository>(),
            provider.GetRequiredService<IValidator<ScheduleBarberServiceCommand>>(),
            provider.GetRequiredService<ILogger<ScheduleBarberServiceCommandHandler>>()
        );
    }

    [Fact]
    public async Task ScheduleBarberService_WithInvalidParameters_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.NewGuid(),
                CustomerId: Guid.NewGuid(),
                ServiceId: 0,
                Date: DateTime.MinValue
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("AppointmentError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task ScheduleBarberService_WithEqualCustomerAndBarber_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                ServiceId: 1,
                Date: DateTime.UtcNow.AddDays(1)
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.InvalidAppointment, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithIncorrectCustomerId_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.NewGuid(),
                CustomerId: Guid.NewGuid(),
                ServiceId: 1,
                Date: DateTime.UtcNow.AddDays(1)
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(CustomerErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithIncorrectBarberId_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.NewGuid(),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.UtcNow.AddDays(1)
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithIncorrectServiceId_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 999,
                Date: DateTime.UtcNow.AddDays(1)
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.ServiceNotFound, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithDateTimeInPast_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.UtcNow.AddDays(-5)
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.InvalidDate, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithInvalidAvailabilityDate_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.Parse("2025-11-25T23:50:00Z").ToUniversalTime()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotAvailableAtDate, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithInvalidAvailabilityStartTime_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.Parse("2025-11-24T09:00:00Z").ToUniversalTime()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotAvailableStartTime, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithHasAppointAtTime_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.Parse("2025-11-24T12:30:00Z").ToUniversalTime()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.AppointmentExistsAtTime, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithNotAvailableAtEndTime_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.Parse("2025-11-24T19:50:00Z").ToUniversalTime()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(BarberErrors.NotAvailableAtTime, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithHasAppointmentEndTimeCollision_ShouldFail()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 1,
                Date: DateTime.Parse("2025-11-24T12:20:00Z").ToUniversalTime()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.EndTimeCollision, result.Error);
    }

    [Fact]
    public async Task ScheduleBarberService_WithValidArguments_ShouldReturnAppointment()
    {
        // arrange
        var command = new ScheduleBarberServiceCommand(
            new RegisterAppointmentRequest(
                BarberId: Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
                CustomerId: Guid.Parse("6f76249a-c359-4ee3-aba8-80fc0f60def7"),
                ServiceId: 11,
                Date: DateTime.Parse("2025-11-24T17:30:00Z").ToUniversalTime()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(DateTime.Parse("2025-11-24T17:30:00Z").ToUniversalTime(), result.Data.Date);
        Assert.Equal(11, result.Data.Service.Id);
        Assert.Equal(AppointmentStatus.WaitingForAprovement, result.Data.Status);
    }
}
