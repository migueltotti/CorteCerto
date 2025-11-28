using CorteCerto.App.Interfaces;
using CorteCerto.App.Pages;
using CorteCerto.App.Services;
using CorteCerto.Application.Services;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.UseCases.Queries.People;
using CorteCerto.Application.Validations;
using CorteCerto.Domain.Interfaces.Gateways;
using CorteCerto.Domain.Interfaces.Repositories;
using CorteCerto.Domain.Interfaces.Services;
using CorteCerto.Domain.Services;
using CorteCerto.Infrastructure.Authentication;
using CorteCerto.Infrastructure.Context;
using CorteCerto.Infrastructure.Gateways;
using CorteCerto.Infrastructure.Repositories;
using FluentValidation;
using LiteBus.Commands.Extensions.MicrosoftDependencyInjection;
using LiteBus.Messaging.Extensions.MicrosoftDependencyInjection;
using LiteBus.Queries.Extensions.MicrosoftDependencyInjection;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App.Infra;

internal static class ConfigureDI
{
    public static ServiceProvider serviceProvider;

    public static void ConfigureService()
    {
        var dbConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

        var services = new ServiceCollection();

        services.AddDbContext<CorteCertoDbContext>(options =>
        {
            options.LogTo(Console.WriteLine);
            options.UseNpgsql(dbConnectionString);
        });

        #region Repositories
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();
        services.AddScoped<IBarberRepository, BarberRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IPersonRepository, PersonRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<IStateRepository, StateRepository>();
        #endregion

        #region Validations
        services.AddValidatorsFromAssemblyContaining<CreateAccountValidator>();
        #endregion

        #region Services
        services.AddLiteBus(liteBus =>
        {
            liteBus.AddCommandModule(module =>
            {
                module.RegisterFromAssembly(typeof(LoginCommandHandler).Assembly);
            });

            liteBus.AddQueryModule(module =>
            {
                module.RegisterFromAssembly(typeof(GetServicesQueryHandler).Assembly);
            });
        });
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IPasswordHashService, PasswordHashService>();
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<ITokenProvider, TokenProvider>();
        services.AddScoped<IViaCepGateway, ViaCepGateway>();
        services.AddSingleton<ISessionService, SessionService>();
        services.AddSingleton<INavegationService, NavegationService>();
        #endregion

        #region Login
        services.AddLogging();
        #endregion

        #region Mappers
        services.AddMapster();
        #endregion

        #region Forms
        services.AddSingleton<MainForm>();
        services.AddTransient<LoginForm>();
        services.AddTransient<CreateAccountForm>();
        #endregion

        serviceProvider = services.BuildServiceProvider();
    }
}
