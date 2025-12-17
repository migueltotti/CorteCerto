namespace CorteCerto.Application.Requests;

public record CreateAccountRequest(
    string Name,
    string Email,
    string Password,
    string PhoneNumber
);