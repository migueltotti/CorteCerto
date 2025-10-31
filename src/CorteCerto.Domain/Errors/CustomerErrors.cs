using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Errors;

public static class CustomerErrors
{
    public static Error EmailAlreadyInUse => new(
        "CustomerError.EmailAlreadyInUse", 
        "Email já está em uso.");
}
