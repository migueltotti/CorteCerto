using CorteCerto.Domain.Base;

namespace CorteCerto.Application.Interfaces;

public interface IEmailGateway
{
    Task SendEmailAsync(string toName, string toEmail, string subject, string body, CancellationToken cancellationToken); 
}