using CorteCerto.Application.Interfaces;
using CorteCerto.Application.Requests;
using CorteCerto.Application.Services;
using CorteCerto.Application.UseCases.Commands.Barbers;
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

namespace CorteCerto.UnitTests.Application;

public class ApproveAppointmentTest
{
    private readonly ServiceProvider provider;
    private readonly ApproveAppointmentCommandHandler commandHandler;

    public ApproveAppointmentTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<IValidator<ApproveAppointmentCommand>, ApproveAppointmentValidator>();
        services.AddTransient<IEmailService, EmailService>();
        services.AddLogging();
        services.AddMapster();

        provider = services.BuildServiceProvider();

        commandHandler = new ApproveAppointmentCommandHandler(
            provider.GetRequiredService<IAppointmentRepository>(),
            provider.GetRequiredService<IValidator<ApproveAppointmentCommand>>(),
            provider.GetRequiredService<IEmailService>(),
            provider.GetRequiredService<ILogger<ApproveAppointmentCommandHandler>>());
    }

    [Fact]
    public async Task ApproveAppointment_WithIncorrectAppointmentId_ShouldFail()
    {
        // Arrange
        var command = new ApproveAppointmentCommand(
            Guid.NewGuid(),
            new ApproveAppointmentRequest(
                Guid.NewGuid()
            )
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.NotFoundById, result.Error);
    }

    [Fact]
    public async Task ApproveAppointment_WithIncorrectBarberId_ShouldFail()
    {
        // Arrange
        var command = new ApproveAppointmentCommand(
            Guid.Parse("ff410b56-fa74-409a-8c8e-f0f94885f1d5"),
            new ApproveAppointmentRequest(Guid.NewGuid())
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.BarberIdMismatch, result.Error);
    }

    [Fact]
    public async Task ApproveAppointment_WithIncorrectAppointmentStatus_ShouldFail()
    {
        // Arrange
        var command = new ApproveAppointmentCommand(
            Guid.Parse("b38fa14d-d01e-4ed6-b850-a4a2695c6962"),
            new ApproveAppointmentRequest(Guid.Parse("c160437f-405c-4203-824f-033b827a089c"))
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AppointmentErrors.AprovementFailed, result.Error);
    }

    [Fact]
    public async Task ApproveAppointment_WithValidArguments_ShouldApproveAppointmentWithSuccess()
    {
        // Arrange
        var command = new ApproveAppointmentCommand(
            Guid.Parse("ff410b56-fa74-409a-8c8e-f0f94885f1d5"),
            new ApproveAppointmentRequest(Guid.Parse("c160437f-405c-4203-824f-033b827a089c"))
        );

        // Act
        var result = await commandHandler.HandleAsync(command, CancellationToken.None);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(Guid.Parse("ff410b56-fa74-409a-8c8e-f0f94885f1d5"), result.Data.Id);
        Assert.Equal(Guid.Parse("c160437f-405c-4203-824f-033b827a089c"), result.Data.Barber.Id);
        Assert.Equal(AppointmentStatus.Scheduled, result.Data.Status);
    }
}
