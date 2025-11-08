using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Application.DTO;

public record ServiceDto(
    int Id,
    string Name,
    string Description,
    TimeSpan Duration,
    bool IsAvailable,
    BarberDto Barber
);
