using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.App.Interfaces;

public interface ICustomMediator
{
    Task<TResult> SendAsync<TResult>(ICommand<TResult> command) where TResult : class;

    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query) where TResult : class;
}
