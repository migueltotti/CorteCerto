using CorteCerto.Application.Interfaces;
using CorteCerto.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CorteCerto.Application.Services;

public class EmailService(IEmailGateway gateway, ILogger<EmailService> logger) : IEmailService
{
    public async Task SendUserEmailConfirmationAsync(Customer customer, CancellationToken cancellationToken)
    {
        var subject = "Confirme seu email";
        var body = $"""
                    Olá, {customer.Name}

                    Seja bem-vindo(a)! 🎉

                    Recebemos sua solicitação para criar uma conta em nosso aplicativo.

                    Para concluir seu cadastro e ativar sua conta, confirme seu endereço de e-mail clicando no botão abaixo:

                    👉 Confirmar meu e-mail
                    https://cortecerto.ofc.com.br/{Guid.NewGuid()}/confirmar-meu-e-mail

                    Este link é válido por 3 horas.

                    Se você não criou esta conta, pode ignorar este e-mail com segurança.

                    Caso tenha qualquer dúvida, nossa equipe de suporte está à disposição para ajudar.

                    Atenciosamente,
                    Equipe Corte Certo
                    """;

        await gateway.SendEmailAsync(customer.Name, customer.Email, subject, body, cancellationToken);
    }

    public async Task SendCustomerAppointmentRequestedNotificationAsync(Appointment appointment,
        CancellationToken cancellationToken)
    {
        var customer = appointment.Customer;
        var barber = appointment.Barber;
        var service = appointment.Service;

        var subject = "Pedido de Agendamento Enviado";
        var body = $"""
                    Olá, {customer.Name}

                    Seu pedido de agendamento foi enviado com sucesso para o barbeiro.

                    Agora é só aguardar a confirmação. Abaixo estão os detalhes da sua solicitação:

                    ----------------------------------------------------------------------------------------------------

                    📌 Detalhes do Agendamento

                    👤 Cliente:
                    {customer.Name}

                    ✂️ Barbeiro:
                    {barber.Name}

                    📍 Endereço do Barbeiro:
                    {barber.Address.Street}, {barber.Address.Number}
                    {barber.Address.Neighborhood}
                    {barber.Address.City.Name} - {barber.Address.City.State.Name}

                    ----------------------------------------------------------------------------------------------------

                    💈 Serviço Solicitado

                    Nome do Serviço: {service.Name}
                    ID do Serviço: {service.Id}
                    Preço: R$ {service.Price:F2}
                    Duração: {service.Duration.TotalMinutes} minutos

                    ----------------------------------------------------------------------------------------------------

                    ⏳ Prazo máximo para resposta do barbeiro:
                    {appointment.ResponseDeadline.TotalHours} horas

                    Você será notificado assim que o barbeiro aceitar ou recusar o seu pedido.

                    Caso precise acompanhar ou cancelar a solicitação, acesse sua área de agendamentos no aplicativo.

                    Obrigado por utilizar o Corte Certo!

                    Atenciosamente,
                    Equipe Corte Certo
                    """;

        await gateway.SendEmailAsync(customer.Name, customer.Email, subject, body, cancellationToken);
    }

    public async Task SendCustomerAppointmentScheduledNotificationAsync(Appointment appointment,
        CancellationToken cancellationToken)
    {
        var customer = appointment.Customer;
        var barber = appointment.Barber;
        var service = appointment.Service;
        var brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(appointment.Date, brazilTimeZone);

        var subject = "Pedido de Agendamento Aceito";
        var body = $"""
                    Olá, {customer.Name} 🎉

                    Ótima notícia! Seu pedido de agendamento foi aceito pelo barbeiro.

                    ----------------------------------------------------------------------------------------------------

                    ✅ Detalhes Confirmados

                    ✂️ Barbeiro:
                    {barber.Name}

                    💈 Serviço:
                    {service.Name}

                    💰 Valor:
                    R$ {service.Price:F2}

                    ⏱ Duração estimada:
                    {service.Duration.TotalMinutes} minutos

                    📅 Data e horário:
                    {localDateTime.Date:dd/MM/yyyy} às {localDateTime.TimeOfDay}

                    ----------------------------------------------------------------------------------------------------

                    📍 Local do Atendimento
                    {barber.Address.Street}, {barber.Address.Number}
                    {barber.Address.Neighborhood}
                    {barber.Address.City.Name} - {barber.Address.City.State.Name}

                    ----------------------------------------------------------------------------------------------------

                    Recomendamos que você chegue com alguns minutos de antecedência.

                    Caso precise cancelar ou reagendar, acesse sua área de agendamentos no aplicativo.

                    Agradecemos por escolher o Corte Certo.
                    Nos vemos em breve! 💈

                    Atenciosamente,
                    Equipe Corte Certo
                    """;

        await gateway.SendEmailAsync(customer.Name, customer.Email, subject, body, cancellationToken);
    }

    public async Task SendCustomerAppointmentCompletedNotificationAsync(Appointment appointment,
        CancellationToken cancellationToken)
    {
        var customer = appointment.Customer;
        var barber = appointment.Barber;
        var service = appointment.Service;
        var brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(appointment.Date, brazilTimeZone);
        var earnedPoints = (int)service.Price;

        var subject = "Agendamento e Serviço Finalizado";
        var body = $"""
                    Olá, {customer.Name} 🎉

                    Seu agendamento foi finalizado com sucesso. Esperamos que tenha tido uma excelente experiência!

                    ----------------------------------------------------------------------------------------------------

                    💈 Detalhes do Atendimento

                    ✂️ Barbeiro:
                    {barber.Name}

                    💈 Serviço realizado:
                    {service.Name}

                    📅 Data e horário:
                    {localDateTime.Date:dd/MM/yyyy} às {localDateTime.Date.TimeOfDay}

                    ⏱ Duração estimada:
                    {service.Duration.TotalMinutes} minutos

                    💰 Valor:
                    R$ {service.Price:F2}

                    🎁 Você ganhou {earnedPoints} pontos por este atendimento.

                    ----------------------------------------------------------------------------------------------------

                    Se estiver tudo certo, que tal avaliar o atendimento?
                    Seu feedback é muito importante para mantermos a qualidade do serviço.

                    Caso queira agendar novamente, você pode fazer isso a qualquer momento pelo aplicativo.

                    Obrigado por utilizar o Corte Certo 💙
                    Esperamos vê-lo novamente em breve!

                    Atenciosamente,
                    Equipe Corte Certo
                    """;

        await gateway.SendEmailAsync(customer.Name, customer.Email, subject, body, cancellationToken);
    }

    public async Task SendCustomerAppointmentCanceledNotificationAsync(Appointment appointment,
        string cancellationReason,
        CancellationToken cancellationToken)
    {
        var customer = appointment.Customer;
        var barber = appointment.Barber;
        var service = appointment.Service;
        var brazilTimeZone = TimeZoneInfo.FindSystemTimeZoneById("America/Sao_Paulo");
        var localDateTime = TimeZoneInfo.ConvertTimeFromUtc(appointment.Date, brazilTimeZone);

        var subject = "Agendamento Cancelado";
        var body = $"""
                    Olá, {customer.Name}

                    Informamos que seu agendamento foi cancelado.

                    ----------------------------------------------------------------------------------------------------

                    📌 Detalhes do Agendamento

                    ✂️ Barbeiro: {barber.Name}
                    
                    💈 Serviço: {service.Name}
                    
                    📅 Data e horário: {localDateTime.Date:dd/MM/yyyy} às {localDateTime.Date.TimeOfDay}

                    ----------------------------------------------------------------------------------------------------

                    ℹ️ Motivo do Cancelamento
                    {cancellationReason}

                    ----------------------------------------------------------------------------------------------------

                    🔁 Próximos Passos

                    Você pode realizar um novo agendamento a qualquer momento pelo aplicativo.

                    Se precisar de ajuda, nossa equipe está à disposição.

                    Atenciosamente,
                    Equipe Corte Certo
                    """;

        await gateway.SendEmailAsync(customer.Name, customer.Email, subject, body, cancellationToken);
    }
}