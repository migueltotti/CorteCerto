using CorteCerto.Domain.Base;

namespace CorteCerto.Domain.Interfaces.Gateways;

public interface IEmailGateway
{
    Task SendEmailAsync(string toName, string toEmail, string subject, string body, CancellationToken cancellationToken); 
}