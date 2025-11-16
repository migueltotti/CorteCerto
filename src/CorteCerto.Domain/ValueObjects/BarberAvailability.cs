using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.ValueObjects;

public class BarberAvailability
{
    public DayOfWeek DayOfWeek { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }

    private BarberAvailability()
    {
    }

    private BarberAvailability(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
    }

    public static Result<BarberAvailability> Create(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime)
    {
        if (endTime <= startTime)
            return Result<BarberAvailability>.Failure(new Error("BarberAvailabilityError.InvalidTimeRange", "Data de finalização deve vir depois de data de inicio."));

        return Result<BarberAvailability>.Success(new BarberAvailability(
            dayOfWeek,
            startTime.ToUniversalTime(),
            endTime.ToUniversalTime()
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
