using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Domain.Helpers;
using FluentValidation;
namespace CorteCerto.Application.Validations;

public partial class RegisterBarberProfileValidator : AbstractValidator<RegisterBarberProfileCommand>
{
    public RegisterBarberProfileValidator()
    {
        RuleFor(x => x.Request.PersonId)
            .NotNull().WithMessage("Id da Pessoa não pode ser nulo.")
            .NotEmpty().WithMessage("Id da Pessoa é obrigatório.");
        
        RuleFor(x => x.Request.Description)
            .NotNull().WithMessage("Descrição não pode ser nulo.")
            .NotEmpty().WithMessage("Descrição é obrigatório.")
            .MaximumLength(1000).WithMessage("Descrição deve ter no máximo 1000 caracteres.");
        
        RuleFor(x => x.Request.Cep)
            .NotNull().WithMessage("Cep não pode ser nulo.")
            .NotEmpty().WithMessage("Cep é obrigatório.")
            .Must(x => CepHelper.Checker.IsMatch(x)).WithMessage("Cep deve estar no formato 00000-000 ou 00000000.");
        
        RuleFor(x => x.Request.AddressNumber)
            .NotNull().WithMessage("Numero de Endereço não pode ser nulo.")
            .NotEmpty().WithMessage("Numero de Endereço é obrigatório.")
            .Must(x => x > 0).WithMessage("Numero de Endereço não pode ser negativo.");
    }
}
