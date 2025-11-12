using CorteCerto.Application.UseCases.Commands.People;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Application.Validations;

public class LoginValidator : AbstractValidator<LoginCommand>
{
    public LoginValidator()
    {
        RuleFor(x => x.Email)
            .NotNull().WithMessage("Email não pode ser nulo.")
            .NotEmpty().WithMessage("Email é obrigatório.")
            .MaximumLength(200).WithMessage("Email deve ter no máximo 100 caracteres.")
            .EmailAddress(EmailValidationMode.AspNetCoreCompatible).WithMessage("Email deve conter '@'.");

        RuleFor(x => x.Password)
            .NotNull().WithMessage("Senha não pode ser nulo.")
            .NotEmpty().WithMessage("Senha é obrigatório.")
            .MinimumLength(8).WithMessage("Senha deve ter no mínimo 8 caracteres.")
            .MaximumLength(30).WithMessage("Senha deve ter no máximo 30 caracteres.");
    }
}
