using CorteCerto.Infrastructure.Models;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Options;

namespace CorteCerto.Infrastructure.Factories;

public class SmtpClientFactory(IOptions<SmtpClientSettings> settings) : ISmtpClientFactory
{
    public async Task<ISmtpClient> CreateClient(CancellationToken cancellationToken)
    {
        var smtpClient = new SmtpClient();

        await smtpClient.ConnectAsync(settings.Value.Host, settings.Value.Port, false, cancellationToken);
        await smtpClient.AuthenticateAsync(settings.Value.Username, settings.Value.Password, cancellationToken);
        
        return smtpClient;
    }
}