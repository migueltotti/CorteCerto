using CorteCerto.Application.UseCases.Commands;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorteCerto.UnitTests.Application;

public class RegisterServiceTest
{
    private readonly ServiceProvider provider;
    private readonly RegisterServiceCommandHandler commandHandler;

    public RegisterServiceTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>();
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddLogging();
        services.AddMapster();
        services.AddScoped<IValidator<RegisterServiceCommand>, RegisterServiceValidator>();

        provider = services.BuildServiceProvider();

        commandHandler = new RegisterServiceCommandHandler(
            provider.GetRequiredService<IBarberRepository>(),
            provider.GetRequiredService<IValidator<RegisterServiceCommand>>(),
            provider.GetRequiredService<ILogger<RegisterServiceCommandHandler>>()
        );
    }


    [Fact]
    public async Task RegisterService_WithInvalidParameters_ShouldFail()
    {
        // arrange
        var command = new RegisterServiceCommand(
            Guid.NewGuid(),
            "",
            "",
            1231231.7298739M,
            TimeSpan.FromMinutes(5)
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("ServiceError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task RegisterService_WithInvalidBarberId_ShouldFail()
    {
        // arrange
        var command = new RegisterServiceCommand(
            Guid.NewGuid(),
            "Teste Certo",
            "Teste Certo",
            0.00M,
            TimeSpan.FromMinutes(25)
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("BarberError.NotFoundById", result.Error.Code);
    }

    [Fact]
    public async Task RegisterService_WithInvalidDuration_ShouldFail()
    {
        // arrange
        var command = new RegisterServiceCommand(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            "Teste Certo",
            "Teste Certo",
            0.00M,
            TimeSpan.FromMinutes(10)
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("ServiceError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task RegisterService_WithValidArguments_ShouldBeSuccess()
    {   
        // arrange
        var command = new RegisterServiceCommand(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            "Cabelo e Barba Pelo Root Agregate",
            "Teste do serviço cabelo e barba pelo root agregate (Barber)!",
            115.0M,
            TimeSpan.FromHours(2)
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(Guid.Parse("c160437f-405c-4203-824f-033b827a089c"), result.Data.Barber.Id);
    }
}
