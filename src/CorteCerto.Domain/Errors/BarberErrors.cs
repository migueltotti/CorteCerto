using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Errors;

public static class BarberErrors
{
    public static Error NotFoundById => new Error(
        "BarberError.NotFoundById",
        "Barbeiro com esse Id não encontrado."
    );

    public static Error ServiceNotFound => new Error(
        "BarberError.ServiceNotFound",
        "Serviço não existe ou não pertence a esse Barbeiro com esse Id."
    );

    public static Error NotAvailableAtDate => new Error(
        "BarberError.NotAvailableAtDate",
        "Barbeiro não está disponivel nesse dia da semana."
    );

    public static Error NotAvailableStartTime => new Error(
        "BarberError.NotAvailableAtDate",
        "Barbeiro ainda não está disponivel neste horario, ficará disponivel mais tarde."
    );

    public static Error NotAvailableAtTime => new Error(
        "BarberError.NotAvailableAtDate",
        "Barbeiro não está disponivel nesse horario do dia."
    );

    public static Error ValidationError(string details) => new(
        "BarberError.ValidationError",
        details);
}
