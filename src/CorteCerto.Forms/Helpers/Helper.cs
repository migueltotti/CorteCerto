using CorteCerto.Domain.Enums;
using CorteCerto.Domain.Filters;
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

    public static string ToPortuguese(this AppointmentStatus status)
    {
        return status switch
        {
            AppointmentStatus.WaitingForAprovement => "Aguardando aprovação",
            AppointmentStatus.Scheduled => "Agendado",
            AppointmentStatus.Completed => "Finalizado",
            AppointmentStatus.Canceled => "Cancelado",
            _ => throw new NotImplementedException()
        };
    }

    public static PriceOperator ToPriceOperator(this string portuguesePriceOperator)
    {
        return portuguesePriceOperator switch
        {
            "Menor que" => PriceOperator.LessThan,
            "Igual" => PriceOperator.Equal,
            "Maior que" => PriceOperator.GreaterThan,
            _ => throw new NotImplementedException()
        };
    }

    public static DurationOperator ToDurationOperator(this string portugueseDurationOperator)
    {
        return portugueseDurationOperator switch
        {
            "Menor que" => DurationOperator.LessThan,
            "Igual" => DurationOperator.Equal,
            "Maior que" => DurationOperator.GreaterThan,
            _ => throw new NotImplementedException()
        };
    }
}
