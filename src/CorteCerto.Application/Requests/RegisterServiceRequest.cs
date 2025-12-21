namespace CorteCerto.Application.Requests;

public record RegisterServiceRequest(
    Guid BarberId,
    string Name,
    string Description,
    decimal Price,
    TimeSpan Duration
);