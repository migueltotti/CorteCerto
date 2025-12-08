namespace CorteCerto.Application.DTO;

public record AddressDto(
     string Street,
     string Neighborhood,
     int Number,
     string ZipCode,
     string City,
     string State,
     string Country
);
