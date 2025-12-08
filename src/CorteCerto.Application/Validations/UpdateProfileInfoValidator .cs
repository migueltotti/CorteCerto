using CorteCerto.Application.UseCases.Commands.People;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class UpdateProfileInfoValidator : AbstractValidator<UpdateProfileInfoCommand>
{
    public UpdateProfileInfoValidator()
    {
        RuleFor(x => x.PersonId)
            .NotNull().WithMessage("Id da Pessoa não pode ser nulo.")
            .NotEmpty().WithMessage("Id da Pessoa é obrigatório.");

        RuleFor(x => x.NewName)
            .NotNull().WithMessage("Nome não pode ser nulo.")
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .MinimumLength(5).WithErrorCode("Nome deve ter no minimo 5 caracteres.")
            .MaximumLength(100).WithMessage("Nome deve ter no máximo 100 caracteres.");

        RuleFor(x => x.NewPhoneNumber)
            .NotNull().WithMessage("Telefone não pode ser nulo.")
            .NotEmpty().WithMessage("Telefone é obrigatório.")
            .MaximumLength(11).WithMessage("Numero de telefone inválido, verifique a quantidade de digitos.");
    }
}