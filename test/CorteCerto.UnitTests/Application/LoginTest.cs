using CorteCerto.Application.Services;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Authentication;
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

namespace CorteCerto.UnitTests.Application;

public class LoginTest
{
    private ServiceProvider provider;
    private readonly LoginCommandHandler commandHandler;

    public LoginTest()
    {
        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
            options.UseNpgsql("User ID=developer;Password=123456789;Server=localhost;Port=5432;Database=corteCertoDb;"));
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddScoped<ITokenProvider, TokenProvider>();
        services.AddLogging();
        services.AddMapster();
        services.AddScoped<IValidator<LoginCommand>, LoginValidator>();

        provider = services.BuildServiceProvider();

        commandHandler = new LoginCommandHandler(
            provider.GetRequiredService<IPersonRepository>(),
            provider.GetRequiredService<IValidator<LoginCommand>>(),
            provider.GetRequiredService<IAuthenticationService>(),
            provider.GetRequiredService<ILogger<LoginCommandHandler>>()
        );

        Environment.SetEnvironmentVariable("SECRET_KEY", "piuUGAWduihAI(*!&@#_(!HPIUAGWDIUY(!Y1231`d1231");
        Environment.SetEnvironmentVariable("TOKEN_VALIDITY_IN_MINUTES", "5");
        Environment.SetEnvironmentVariable("VALID_AUDIENCE", "CorteCertoAudience");
        Environment.SetEnvironmentVariable("VALID_ISSUER", "CorteCertoIssuer");
    }

    [Fact]
    public async Task Login_WithInvalidCredentials_ShouldReturnFail()
    {
        // Arrange
        var command = new LoginCommand("sla", "sla2");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("AuthenticationError.LoginValidationError", result.Error.Code);
    }

    [Fact]
    public async Task Login_WithIncorrectEmail_ShouldReturnFail()
    {
        // Arrange
        var command = new LoginCommand("teste12313teste@gmail.com", "EmailIncorreto123@");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AuthenticationErrors.NotFoundByEmail, result.Error);
    }

    [Fact]
    public async Task Login_WithIncorrectPassword_ShouldReturnFail()
    {
        // Arrange
        var command = new LoginCommand("teste2@silva", "EmailIncorreto123@");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AuthenticationErrors.IncorrectPassowrd, result.Error);
    }

    [Fact]
    public async Task Login_WithCorrectCredentials_ShouldReturnSuccess()
    {
        // Arrange
        var command = new LoginCommand("teste2@silva", "Teste123@");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotEmpty(result.Data.AccessToken);
        Assert.NotEmpty(result.Data.RefreshToken);
        Assert.Equal(DateTime.UtcNow.AddMinutes(5).Minute, result.Data.RefreshTokenExpiresAt.Minute);
    }
}
