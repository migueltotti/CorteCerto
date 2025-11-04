using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Helpers;

public static class CepHelper
{
    public static string RemoveHifen(this string cep) => cep.Replace("-", String.Empty);
}
