
namespace CorteCerto.Application.DTO;

public record BarberDto(
    Guid Id,
    string Name,
    string Email,
    string PhoneNumber,
    string Description,
    string PortfolioUrl,
    AddressDto Address,
    List<BarberAvailabilityDto> Availabilities
);
