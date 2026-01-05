namespace CorteCerto.Application.Requests;

public record UpdatePersonPasswordRequest(
    string CurrentPassword,
    string NewPassword
);