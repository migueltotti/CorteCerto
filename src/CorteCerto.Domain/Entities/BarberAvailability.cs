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

    public static Result<BarberAvailability> Create(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime, Barber barber)
    {
        if (endTime <= startTime)
            return Result<BarberAvailability>.Failure(new Error("InvalidTimeRange", "End time must be after start time"));

        return Result<BarberAvailability>.Success(new BarberAvailability(
            dayOfWeek,
            startTime,
            endTime,
            barber
        ));
    }
}
