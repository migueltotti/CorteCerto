using CorteCerto.App.Interfaces;
using CorteCerto.App.Models;
using CorteCerto.App.Pages;
using CorteCerto.App.Services;
using CorteCerto.Application.DTO;
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

        // ✅ DbContext como Scoped (padrão)
        services.AddDbContext<CorteCertoDbContext>(options =>
        {
            options.LogTo(Console.WriteLine);
            options.UseNpgsql(dbConnectionString);
            options.EnableSensitiveDataLogging();
        }, ServiceLifetime.Scoped); // Explícito

        #region Repositories (Scoped - correto)
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

        #region Validations (Singleton - validators são stateless)
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

        // ✅ Singleton - não depende de DbContext
        services.AddSingleton<ISessionService, SessionService>();
        services.AddSingleton<INavegationService, NavegationService>();
        services.AddSingleton<ICustomMediator, CustomMediator>();
        #endregion

        #region Logging
        services.AddLogging();
        #endregion

        #region Mappers
        services.AddMapster();
        TypeAdapterConfig<ServiceDto, ServiceModel>
            .NewConfig()
            .Map(dest => dest.Barber, src => src.Barber.Name);
        #endregion

        #region Forms
        // ✅ TODOS como TRANSIENT - nova instância a cada navegação
        // O scope gerencia o ciclo de vida
        services.AddTransient<MainForm>();
        services.AddTransient<LoginForm>();
        services.AddTransient<CreateAccountForm>();
        services.AddTransient<RegisterAppointmentForm>();
        services.AddTransient<RegisterServiceForm>();
        services.AddTransient<RegisterBarberProfileForm>();
        #endregion

        serviceProvider = services.BuildServiceProvider();
    }
}
