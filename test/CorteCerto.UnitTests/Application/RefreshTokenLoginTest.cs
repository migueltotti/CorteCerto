using CorteCerto.Application.Services;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.Validations;
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
using Microsoft.Extensions.Options;

namespace CorteCerto.UnitTests.Application;

public class RefreshTokenLoginTest
{
    private ServiceProvider provider;
    private readonly RefreshTokenLoginCommandHandler commandHandler;

    public RefreshTokenLoginTest()
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
        services.AddScoped<IValidator<RefreshTokenLoginCommand>, RefreshTokenLoginValidator>();
        var settings = new JwtSettings()
        {
            SecretKey = "piuUGAWduihAI(*!&@#_(!HPIUAGWDIUY(!Y1231`d1231",
            TokenValidityInMinutes = 10,
            Audience = "CorteCerto.Api",
            Issuer = "CorteCerto.Api"
        };
        services.AddSingleton<IOptions<JwtSettings>>(Options.Create(settings));

        provider = services.BuildServiceProvider();

        commandHandler = new RefreshTokenLoginCommandHandler(
            provider.GetRequiredService<IAuthenticationService>(),
            provider.GetRequiredService<IValidator<RefreshTokenLoginCommand>>(),
            provider.GetRequiredService<ILogger<RefreshTokenLoginCommandHandler>>()
        );
    }
    
    [Fact]
    public async Task RefreshTokenLogin_WithInvalidCredentials_ShouldReturnFail()
    {
        // Arrange
        var command = new RefreshTokenLoginCommand("", "");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal("AuthenticationError.LoginValidationError", result.Error.Code);
    }
    
    [Fact]
    public async Task RefreshTokenLogin_WithExpiredRefreshTokenCredentials_ShouldReturnFail()
    {
        // Arrange
        var command = new RefreshTokenLoginCommand(
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0ZTBiMmYzNi00OTNjLTQ3MDMtOGEwNS0xYWYxZjE0OWVkZjYiLCJlbWFpbCI6InRlc3RlNEBhcGkuY29tIiwidW5pcXVlX25hbWUiOiJUZXN0ZTMgQVBJIEF0dWFsaXphZG8iLCJuYmYiOjE3NjY1ODQ3NDksImV4cCI6MTc2NjU4NTM0OSwiaWF0IjoxNzY2NTg0NzQ5LCJpc3MiOiJDb3J0ZUNlcnRvLkFwaSIsImF1ZCI6IkNvcnRlQ2VydG8uQXBpIn0.Wrrs1hOda2xOhvMM5ZEB17nccSOUxg91N9kw_DUaaGQ", 
            "Bayp2wT5DlkB4TtzzZ05LY1P+h/6r/zzcG6LsUNE1Wvkyxb40D3kJyvps7wH4XfH4LLEOLkQ8nGskmgS4SGkQ06RBv1pdjeSv8WUpGDsnHuRMKAwfMVFSSJguhyZ/YxouQ68Uw1lIkgwPV4JL/Q8GP96ZC75DVMr7aRQgwSCVHE=");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(result.Error, AuthenticationErrors.RefreshTokenExpired);
    }
    
    [Fact]
    public async Task RefreshTokenLogin_WithValidCredentials_ShouldReturnSuccess()
    {
        // Arrange
        var command = new RefreshTokenLoginCommand(
            "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI0ZTBiMmYzNi00OTNjLTQ3MDMtOGEwNS0xYWYxZjE0OWVkZjYiLCJlbWFpbCI6InRlc3RlNEBhcGkuY29tIiwidW5pcXVlX25hbWUiOiJUZXN0ZTMgQVBJIEF0dWFsaXphZG8iLCJuYmYiOjE3NjY2NjU4MDEsImV4cCI6MTc2NjY2NjQwMSwiaWF0IjoxNzY2NjY1ODAxLCJpc3MiOiJDb3J0ZUNlcnRvLkFwaSIsImF1ZCI6IkNvcnRlQ2VydG8uQXBpIn0.-gTxeDLJ9Z6mK_212vIaf2wQNBVInksAhXnQwk5R4uI", 
            "KODAw1wEiNg8/akLMB83lVdjfKUBwG1OGddc2oW0xBYo/5Z6qa0T2aRv6THgqKO4dq1gF658jmupvoCWkuL2kGzkboXVI7juIkcCYepCSB6gQ+PNxxPgHPr5d6q1ZRxNpMdyQMerKNzFHA2C2CE/fOe6RahOUQz0E/qAgtgZ+J0=");

        // Act
        var result = await commandHandler.HandleAsync(command);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.NotEmpty(result.Data.AccessToken);
        Assert.NotEmpty(result.Data.RefreshToken);
        Assert.Equal(DateTime.UtcNow.AddMinutes(30).Minute, result.Data.RefreshTokenExpiresAt.Minute);
    }
}