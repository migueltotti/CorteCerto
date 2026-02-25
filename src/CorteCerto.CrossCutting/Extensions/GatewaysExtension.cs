using CorteCerto.Domain.Interfaces.Gateways;
using CorteCerto.Infrastructure.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class GatewaysExtension
{
    public static IServiceCollection AddGateways(this IServiceCollection services)
    {
        services.AddTransient<IEmailGateway, EmailGateway>();

        return services;
    }
}