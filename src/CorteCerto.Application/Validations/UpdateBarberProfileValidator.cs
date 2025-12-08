using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Domain.Helpers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class UpdateBarberProfileValidator : AbstractValidator<UpdateBarberProfileCommand>
{
    public UpdateBarberProfileValidator()
    {
        RuleFor(x => x.BarberId)
            .NotNull().WithMessage("Id do barbeiro não pode ser nulo.")
            .NotEmpty().WithMessage("Id do barbeiro é obrigatório.");

        RuleFor(x => x.Name)
            .NotNull().WithMessage("Nome não pode ser nulo.")
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .MinimumLength(5).WithErrorCode("Nome deve ter no minimo 5 caracteres.")
            .MaximumLength(100).WithMessage("Nome deve ter no máximo 100 caracteres.");

        RuleFor(x => x.Description)
            .NotNull().WithMessage("Descrição não pode ser nulo.")
            .NotEmpty().WithMessage("Descrição é obrigatório.")
            .MaximumLength(1000).WithMessage("Descrição deve ter no máximo 1000 caracteres.");

        RuleFor(x => x.PhoneNumber)
            .NotNull().WithMessage("Telefone não pode ser nulo.")
            .NotEmpty().WithMessage("Telefone é obrigatório.")
            .MaximumLength(15).WithMessage("Numero de telefone inválido, verifique a quantidade de digitos.");

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
