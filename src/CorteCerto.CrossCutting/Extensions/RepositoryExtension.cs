using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class RepositoryExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<IStateRepository, StateRepository>();
        
        return services;
    }
}