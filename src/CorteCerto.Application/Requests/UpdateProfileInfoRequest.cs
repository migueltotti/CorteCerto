namespace CorteCerto.Application.Requests;

public record UpdateProfileInfoRequest(
    string NewName,
    string NewPhoneNumber
);