using CorteCerto.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Domain.Entities;

public class BarberAvailability : BaseEntity<int>
{
    public DayOfWeek DayOfWeek { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public Barber Barber { get; private set; }

    private BarberAvailability()
    {
    }

    private BarberAvailability(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime, Barber barber)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
        Barber = barber;
    }

    public static Result<BarberAvailability> Create(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime)
    {
        if (endTime <= startTime)
            return Result<BarberAvailability>.Failure(new Error("BarberAvailabilityError.InvalidTimeRange", "Data de finalização deve vir depois de data de inicio."));

        return Result<BarberAvailability>.Success(new BarberAvailability(
            dayOfWeek,
            startTime.ToUniversalTime(),
            endTime.ToUniversalTime(),
            null
        ));
    }

    public void SetStartTime(DateTime startTime)
    {
        StartTime = startTime;
    }

    public void SetEndTime(DateTime endTime)
    {
        EndTime = endTime;
    }
}
