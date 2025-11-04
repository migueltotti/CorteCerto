using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteCerto.Application.DTO;

public record BarberDto(
    Guid Id,
    string Name,
    string Email,
    string PhoneNumber
);
