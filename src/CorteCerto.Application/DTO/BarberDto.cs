
namespace CorteCerto.Application.DTO;

public record BarberDto(
    Guid Id,
    string Name,
    string Email,
    string PhoneNumber,
    string Description,
    List<BarberAvailabilityDto> Availabilities
);
