namespace CorteCerto.App.Models;

internal record ServiceModel(
    int Id,
    string Name,
    string Description,
    decimal Price,
    TimeSpan Duration,
    string Barber
);
