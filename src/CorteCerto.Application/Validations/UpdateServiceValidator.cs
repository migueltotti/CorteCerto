using CorteCerto.Application.UseCases.Commands.Barbers;
using FluentValidation;

namespace CorteCerto.Application.Validations;

public class UpdateServiceValidator : AbstractValidator<UpdateServiceCommand>
{
    public UpdateServiceValidator()
    {
        RuleFor(x => x.BarberId)
            .NotNull().WithMessage("Id do barbeiro não pode ser nulo.")
            .NotEmpty().WithMessage("Id do barbeiro é obrigatório.");

        RuleFor(x => x.ServiceId)
            .NotNull().WithMessage("Id do serviço não pode ser nulo.")
            .NotEmpty().WithMessage("Id do serviço é obrigatório.");

        RuleFor(x => x.Name)
            .NotNull().WithMessage("Nome não pode ser nulo.")
            .NotEmpty().WithMessage("Nome é obrigatório.")
            .MaximumLength(200).WithMessage("Nome deve ter no máximo 200 caracteres");

        RuleFor(x => x.Description)
            .NotNull().WithMessage("Descrição não pode ser nulo.")
            .NotEmpty().WithMessage("Descrição é obrigatório.")
            .MaximumLength(1000).WithMessage("Descrição deve ter no máximo 1000 caracteres");

        RuleFor(x => x.Duration)
            .NotNull().WithMessage("Duração não pode ser nulo.")
            .NotEmpty().WithMessage("Duração é obrigatório.")
            .GreaterThan(TimeSpan.FromMinutes(15)).WithMessage("Duração deve tempo minimo de 15 minutos")
            .LessThan(TimeSpan.FromDays(1)).WithMessage("Duração deve ter tempo máximo de 1 dia");

        RuleFor(x => x.Price)
            .NotNull().WithMessage("Preço não pode ser nulo.")
            .PrecisionScale(10, 2, true).WithMessage("Preço deve ter uma precisão de 10 e uma escala decimal de 2 casas.");

        RuleFor(x => x.IsAvailable)
            .NotNull().WithMessage("Disponibilidade não pode ser nulo.");
    }
}
