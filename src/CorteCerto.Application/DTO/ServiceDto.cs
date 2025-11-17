namespace CorteCerto.Application.DTO;

public record ServiceDto(
    int Id,
    string Name,
    string Description,
    decimal Price,
    TimeSpan Duration,
    bool IsAvailable,
    BarberDto Barber
);
