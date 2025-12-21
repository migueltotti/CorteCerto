namespace CorteCerto.Application.Requests;

public record UpdateBarberProfileRequest(
    Guid BarberId, 
    string Name,
    string Description,
    string? PortfolioUrl,
    string PhoneNumber,
    string Cep,
    int AddressNumber
);