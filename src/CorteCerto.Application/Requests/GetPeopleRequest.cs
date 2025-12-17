namespace CorteCerto.Application.Requests;

public record GetPeopleRequest(
    IEnumerable<Guid>? Ids = null,
    string? Name = null,
    string? Email = null,
    int PageSize = 50,
    int PageNumber = 1
);