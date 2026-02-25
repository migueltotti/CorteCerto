using MailKit.Net.Smtp;

namespace CorteCerto.Infrastructure.Factories;

public interface ISmtpClientFactory
{
    Task<ISmtpClient> CreateClient(CancellationToken cancellationToken);
}