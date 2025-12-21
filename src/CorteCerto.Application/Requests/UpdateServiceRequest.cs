namespace CorteCerto.Application.Requests;

public record UpdateServiceRequest(
    Guid BarberId,
    string Name,
    string Description,
    decimal Price,
    TimeSpan Duration,
    bool IsAvailable
);