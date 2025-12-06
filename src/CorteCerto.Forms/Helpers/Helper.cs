using System.Text.RegularExpressions;

namespace CorteCerto.App.Helpers;

public static partial class Helper
{
    public static string GetNumbers(this string value)
    {
        var regex = new Regex(@"\D");

        return regex.Replace(value ?? string.Empty, string.Empty);
    }

    public static string ToPortuguese(this DayOfWeek dayOfWeek)
    {
        return dayOfWeek switch
        {
            DayOfWeek.Sunday => "Domingo",
            DayOfWeek.Monday => "Segunda",
            DayOfWeek.Tuesday => "Terça",
            DayOfWeek.Wednesday => "Quarta",
            DayOfWeek.Thursday => "Quinta",
            DayOfWeek.Friday => "Sexta",
            DayOfWeek.Saturday => "Sábado",
            _ => throw new NotImplementedException()
        };
    }
}
