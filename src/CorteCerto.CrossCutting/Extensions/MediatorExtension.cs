using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.UseCases.Queries.Barbers;
using LiteBus.Commands;
using LiteBus.Extensions.Microsoft.DependencyInjection;
using LiteBus.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class MediatorExtension
{
    public static IServiceCollection AddMediator(this IServiceCollection services)
    {
        services.AddLiteBus(config =>
        {
            config.AddCommandModule(command =>
            {
                command.RegisterFromAssembly(typeof(LoginCommand).Assembly);
            });
            
            config.AddQueryModule(query =>
            {
                query.RegisterFromAssembly(typeof(GetBarbersQuery).Assembly);
            });
        });
        
        return services;
    }
}