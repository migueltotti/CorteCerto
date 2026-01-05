namespace CorteCerto.Application.Requests;

public record UpdatePersonEmailRequest(
    string CurrentEmail,    
    string NewEmail
);