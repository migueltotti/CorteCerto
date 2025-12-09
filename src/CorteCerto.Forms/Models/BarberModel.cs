namespace CorteCerto.App.Models;

internal record BarberModel
(
    Guid Id,
    string Name,
    string Email,
    string PhoneNumber,
    string Description,
    string Address,
    string City,
    string State,
    string Country
);
