using System.Text.RegularExpressions;

namespace CorteCerto.App.Helpers;

public static partial class Helper
{
    public static string GetNumbers(this string value)
    {
        var regex = new Regex(@"\D");

        return regex.Replace(value ?? string.Empty, string.Empty);
    }
}
