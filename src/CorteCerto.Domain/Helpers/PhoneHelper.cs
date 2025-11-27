using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Helpers;

public static class PhoneHelper
{
    public static string FormatPhoneNumber(this string phoneNumber)
    {
        return phoneNumber
            .Replace(" ", "")
            .Replace("(", "")
            .Replace(")", "")
            .Replace("-", "")
            .Trim();
    } 
}
