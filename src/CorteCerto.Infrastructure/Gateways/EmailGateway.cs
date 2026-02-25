using CorteCerto.Application.Interfaces;
using CorteCerto.Infrastructure.Factories;
using CorteCerto.Infrastructure.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;

namespace CorteCerto.Infrastructure.Gateways;

public class EmailGateway(
    ISmtpClientFactory smtpClientFactory,
    ILogger<EmailGateway> logger,
    IOptions<SmtpClientSettings> settings) : IEmailGateway
{
    public async Task SendEmailAsync(string toName, string toEmail, string subject, string body,
        CancellationToken cancellationToken)
    {
        var smtpClient = await smtpClientFactory.CreateClient(cancellationToken);

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(settings.Value.Name, settings.Value.Username));
        message.To.Add(new MailboxAddress(toName, toEmail));

        message.Subject = subject;
        message.Body = new TextPart("plain")
        {
            Text = body
        };

        await smtpClient.SendAsync(message, cancellationToken);
        await smtpClient.DisconnectAsync(true, cancellationToken);

        logger.LogInformation("EmailGateway - Sending Email To {ToEmail} - Subject: {Subject}", toEmail, subject);
    }
}