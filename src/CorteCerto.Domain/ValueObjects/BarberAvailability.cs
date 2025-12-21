using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.ValueObjects;

public class BarberAvailability
{
    public DayOfWeek DayOfWeek { get; private set; }
    public TimeOnly StartTime { get; private set; }
    public TimeOnly EndTime { get; private set; }

    private BarberAvailability()
    {
    }

    private BarberAvailability(DayOfWeek dayOfWeek, TimeOnly startTime, TimeOnly endTime)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
    }

    public static Result<BarberAvailability> Create(DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime)
    {
        if (endTime <= startTime)
            return Result<BarberAvailability>.Failure(new Error("BarberAvailabilityError.InvalidTimeRange", "Data de finalização deve vir depois de data de inicio."));

        var utcStartTime = TimeOnly.FromDateTime(startTime.ToUniversalTime());
        var utcEndTime = TimeOnly.FromDateTime(endTime.ToUniversalTime());
        
        return Result<BarberAvailability>.Success(new BarberAvailability(
            dayOfWeek,
            utcStartTime,
            utcEndTime
        ));
    }

    public void SetStartTime(TimeOnly startTime)
    {
        StartTime = startTime;
    }

    public void SetEndTime(TimeOnly endTime)
    {
        EndTime = endTime;
    }

    public (DateTime startTime, DateTime endTime) GetTimeAvailabilityFormatedForAppointmentDate(DateTime appointmentDate)
    {
        var appointmentDateOnly = DateOnly.FromDateTime(appointmentDate.ToUniversalTime());

        var startTime = appointmentDateOnly.ToDateTime(StartTime, DateTimeKind.Utc);
        
        var endTime = EndTime > StartTime ?
            appointmentDateOnly.ToDateTime(EndTime, DateTimeKind.Utc) :
            appointmentDateOnly.AddDays(1).ToDateTime(EndTime, DateTimeKind.Utc);
        
        return (startTime, endTime);
    }
}
