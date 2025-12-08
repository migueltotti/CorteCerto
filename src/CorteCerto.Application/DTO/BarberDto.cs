
namespace CorteCerto.Application.DTO;

public record BarberDto(
    Guid Id,
    string Name,
    string Email,
    string PhoneNumber,
    string Description,
    string ProfileUrl,
    AddressDto Address,
    List<BarberAvailabilityDto> Availabilities
);
