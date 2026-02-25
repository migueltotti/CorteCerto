using CorteCerto.CrossCutting.Models;
using CorteCerto.Domain.Interfaces.Gateways;
using CorteCerto.Infrastructure.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class HttpClientExtension
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddHttpClients(Settings settings)
        {
            services.AddHttpClient<IViaCepClient, ViaCepClient>(options =>
            {
                options.BaseAddress = new Uri(settings.ViaCepSettings.Url);
            });

            return services;
        }
    } 
}