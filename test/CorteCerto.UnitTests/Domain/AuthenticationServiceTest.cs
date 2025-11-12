
using CorteCerto.Application.Services;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Errors;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Domain.ValueObjects;
using CorteCerto.Infrastructure.Authentication;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Repositories;
using Mapster;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CorteCerto.UnitTests.Domain;

public class AuthenticationServiceTest
{
    private readonly IServiceProvider serviceProvider;

    public AuthenticationServiceTest()
    {
        var services = new ServiceCollection();

        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddDbContext<CorteCertoDbContext>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddScoped<ITokenProvider, TokenProvider>();
        services.AddLogging();
        services.AddMapster();

        serviceProvider = services.BuildServiceProvider();

        Environment.SetEnvironmentVariable("SECRET_KEY", "piuUGAWduihAI(*!&@#_(!HPIUAGWDIUY(!Y1231`d1231");
        Environment.SetEnvironmentVariable("TOKEN_VALIDITY_IN_MINUTES", "5");
        Environment.SetEnvironmentVariable("VALID_AUDIENCE", "CorteCertoAudience");
        Environment.SetEnvironmentVariable("VALID_ISSUER", "CorteCertoIssuer");
    }

    [Fact]
    public void Authenticate_WithIncorrectPassword_ShouldReturnFail()
    {
        // Arrange
        var authService = serviceProvider.GetRequiredService<IAuthenticationService>();
        var person = new Customer(
            Guid.NewGuid(),
            "John Doe",
            "johnDoe@gmail.com",
            "18999999999",
            "EDF7457A7CDFF78907CBEC73EEDB49480D1D76F0D7B247B15D9668FAE7DDF7F5-C7259A03D8AC1E280E99458659DD5973"
        );
        var password = "Teste123@1123!@#!WD!";

        // Act
        var result = authService.Authenticate(person, password);

        // Assert
        Assert.True(result.IsFailure);
        Assert.Equal(AuthenticationErrors.IncorrectPassowrd, result.Error);
    }

    [Fact]
    public void Authenticate_WithCorrectPassword_ShouldReturnSucessAndToken()
    {
        // Arrange
        var authService = serviceProvider.GetRequiredService<IAuthenticationService>();
        var person = new Customer(
            Guid.Parse("c160437f-405c-4203-824f-033b827a089c"),
            "Teste da Silva",
            "teste2@silva",
            "18997872005",
            "EDF7457A7CDFF78907CBEC73EEDB49480D1D76F0D7B247B15D9668FAE7DDF7F5-C7259A03D8AC1E280E99458659DD5973"
        );
        var password = "Teste123@";

        // Act
        var result = authService.Authenticate(person, password);

        // Assert
        Assert.True(result.IsSuccess);
        Assert.IsType<Token>(result.Data);
        Assert.NotEmpty(result.Data.AccessToken);
        Assert.NotEmpty(result.Data.RefreshToken);
        Assert.Equal(172, result.Data.RefreshToken.Length);
    }
}
