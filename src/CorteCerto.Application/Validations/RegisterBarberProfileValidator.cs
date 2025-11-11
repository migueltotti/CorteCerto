using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Domain.Helpers;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;
namespace CorteCerto.Application.Validations;

public partial class RegisterBarberProfileValidator : AbstractValidator<RegisterBarberProfileCommand>
{
    public RegisterBarberProfileValidator()
    {
        RuleFor(x => x.PersonId)
            .NotNull().WithMessage("Id da Pessoa não pode ser nulo.")
            .NotEmpty().WithMessage("Id da Pessoa é obrigatório.");
        RuleFor(x => x.Description)
            .NotNull().WithMessage("Descrição não pode ser nulo.")
            .NotEmpty().WithMessage("Descrição é obrigatório.")
            .MaximumLength(1000).WithMessage("Descrição deve ter no máximo 1000 caracteres.");
        RuleFor(x => x.Cep)
            .NotNull().WithMessage("Cep não pode ser nulo.")
            .NotEmpty().WithMessage("Cep é obrigatório.")
            .Must(x => CepHelper.Checker.IsMatch(x)).WithMessage("Cep deve estar no formato NNNNN-NNN ou NNNNNNNN.");
        RuleFor(x => x.AddressNumber)
            .NotNull().WithMessage("Numero de Endereço não pode ser nulo.")
            .NotEmpty().WithMessage("Numero de Endereço é obrigatório.")
            .Must(x => x > 0).WithMessage("Numero de Endereço não pode ser negativo.");
    }

    
}
