using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Errors;

public static class CustomerErrors
{
    public static Error NotFoundById => new(
        "CustomerError.NotFoundById",
        "Cliente com esse Id não encontrado.");

    public static Error NotFoundByEmail => new(
        "CustomerError.NotFoundByEmail",
        "Cliente com esse Email não encontrado.");

    public static Error EmailAlreadyInUse => new(
        "CustomerError.EmailAlreadyInUse", 
        "Email já está em uso.");

    public static Error ValidationError(string details) => new(
        "CustomerError.ValidationError",
        details);
}
