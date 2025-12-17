namespace CorteCerto.Application.DTO;

public record AddressDto
(
    string Street,
    string Neighborhood,
    int Number,
    string ZipCode,
    CityDto City
);