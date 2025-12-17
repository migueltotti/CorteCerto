namespace CorteCerto.Application.DTO;

public record StateDto(
    string Acronym,
    string Name,
    CountryDto Country
);