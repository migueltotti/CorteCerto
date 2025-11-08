using CorteCerto.Application.UseCases.Commands;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Gateways;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.UnitTests.Application;

public class RegisterBarberProfileTest
{

    private readonly ServiceProvider serviceProvider;

    public RegisterBarberProfileTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<IStateRepository, StateRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IViaCepGateway, ViaCepGateway>();
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IValidator<RegisterBarberProfileCommand>, RegisterBarberProfileCommandValidator>();
        services.AddLogging();

        serviceProvider = services.BuildServiceProvider();
    }

    [Fact]
    public async Task RegisterBaberProfile_WithWrongBarberInfos_ShouldFail()
    {
        // Arrange
        var command = new RegisterBarberProfileCommand
        (
            Guid.NewGuid(),
            "", // Invalid description
            null,
            "12345-678",
            100
        );

        var commandHandler = new RegisterBarberProfileCommandHandler(
            serviceProvider.GetRequiredService<IValidator<RegisterBarberProfileCommand>>(),
            serviceProvider.GetRequiredService<IPersonRepository>(),
            serviceProvider.GetRequiredService<IBarberRepository>(),
            serviceProvider.GetRequiredService<IAddressService>(),
            serviceProvider.GetRequiredService<ILogger<RegisterBarberProfileCommandHandler>>()
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("CustomerError.ValidationError", result.Error.Code);
    }

    [Fact]
    public async Task RegisterBaberProfile_WithInvalidPersonId_ShouldFail()
    {
        // Arrange
        var command = new RegisterBarberProfileCommand
        (
            Guid.NewGuid(),
            "Teste Cep inválido", // Invalid description
            null,
            "12345-678",
            100
        );

        var commandHandler = new RegisterBarberProfileCommandHandler(
            serviceProvider.GetRequiredService<IValidator<RegisterBarberProfileCommand>>(),
            serviceProvider.GetRequiredService<IPersonRepository>(),
            serviceProvider.GetRequiredService<IBarberRepository>(),
            serviceProvider.GetRequiredService<IAddressService>(),
            serviceProvider.GetRequiredService<ILogger<RegisterBarberProfileCommandHandler>>()
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("CustomerError.NotFoundById", result.Error.Code);
    }

    [Fact]
    public async Task RegisterBaberProfile_WithInvalidCep_ShouldFail()
    {
        // Arrange
        var command = new RegisterBarberProfileCommand
        (
            Guid.Parse("fceceaf7-2d08-44f7-8752-a5b39ba820ed"),
            "Teste Cep inválido", // Invalid description
            null,
            "12345-678",
            100
        );

        var commandHandler = new RegisterBarberProfileCommandHandler(
            serviceProvider.GetRequiredService<IValidator<RegisterBarberProfileCommand>>(),
            serviceProvider.GetRequiredService<IPersonRepository>(),
            serviceProvider.GetRequiredService<IBarberRepository>(),
            serviceProvider.GetRequiredService<IAddressService>(),
            serviceProvider.GetRequiredService<ILogger<RegisterBarberProfileCommandHandler>>()
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("ViaCepGateway.InvalidZipCode", result.Error.Code);
    }

    [Fact]
    public async Task RegisterBaberProfile_WithValidInfos_ShouldBeSuccess()
    {
        // Arrange
        var command = new RegisterBarberProfileCommand
        (
            Guid.Parse("6bad02d7-b8bf-41bd-bb05-0f58369facf1"),
            "Miguel Teste `3, mesmo Address",
            null,
            "01001-000",
            111
        );

        var commandHandler = new RegisterBarberProfileCommandHandler(
            serviceProvider.GetRequiredService<IValidator<RegisterBarberProfileCommand>>(),
            serviceProvider.GetRequiredService<IPersonRepository>(),
            serviceProvider.GetRequiredService<IBarberRepository>(),
            serviceProvider.GetRequiredService<IAddressService>(),
            serviceProvider.GetRequiredService<ILogger<RegisterBarberProfileCommandHandler>>()
        );

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.Equal(Guid.Parse("6bad02d7-b8bf-41bd-bb05-0f58369facf1"), result.Data.Id);
    }
}
