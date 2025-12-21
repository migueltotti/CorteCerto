namespace CorteCerto.Application.Requests;

public record RegisterBarberProfileRequest(
    Guid PersonId, 
    string Description, 
    string? PortfolioUrl,
    string Cep, 
    int AddressNumber    
);