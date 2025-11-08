using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Errors;

public static class ServiceErrors
{
    public static Error ValidationError(string details) => new(
        "ServiceError.ValidationError",
        details);

    public static Error DurationInvalid => new Error(
        "ServiceError.InvalidDuration",
        "A duração do serviço deve ter no mínimo 15 minutos e no máximo 1 dia.");
}
