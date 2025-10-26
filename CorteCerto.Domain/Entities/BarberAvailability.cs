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

    public BarberAvailability(int id, DayOfWeek dayOfWeek, DateTime startTime, DateTime endTime, Barber barber) : base(id)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
        Barber = barber;
    }
}
