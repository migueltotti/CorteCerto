using CorteCerto.Application.Services;
using CorteCerto.Domain.Interfaces.Gateways;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Authentication;
using CorteCerto.Infrastructure.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class ServicesExtension
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<ITokenProvider, TokenProvider>();
        services.AddScoped<IViaCepGateway, ViaCepGateway>();
        
        return services;
    }
}