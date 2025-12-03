using CorteCerto.App.Infra;
using CorteCerto.App.Interfaces;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App.Services;

internal class CustomMediator : ICustomMediator
{
    public async Task<TResult> QueryAsync<TResult>(IQuery<TResult> query) where TResult : class
    {
        using var scope = ConfigureDI.serviceProvider.CreateScope();

        var queryMediator = scope.ServiceProvider.GetRequiredService<IQueryMediator>();

        return await queryMediator.QueryAsync(query);
    }

    public async Task<TResult> SendAsync<TResult>(ICommand<TResult> command) where TResult : class
    {
        using var scope = ConfigureDI.serviceProvider.CreateScope();

        var commandMediator = scope.ServiceProvider.GetRequiredService<ICommandMediator>();

        return await commandMediator.SendAsync(command);
    }
}
