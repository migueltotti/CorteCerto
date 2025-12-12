using CorteCerto.Application.Validations;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.CrossCutting.Extensions;

public static class ValidatorExtension
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<CreateAccountValidator>();
        
        return services;
    }
}