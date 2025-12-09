using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Domain.Entities;
using ReaLTaiizor.Forms;

namespace CorteCerto.App.Pages
{
    public partial class AppointmentInfoForm : MaterialForm
    {
        private readonly ICustomMediator _mediator;
        private readonly ISessionService _sessionService;
        private AppointmentDto _appointment;

        public AppointmentInfoForm(ICustomMediator mediator, ISessionService sessionService)
        {
            _mediator = mediator;

            InitializeComponent();
            _sessionService = sessionService;
        }

        public void InitializeWithAppointmentDto(AppointmentDto appointment)
        {
            _appointment = appointment;

            lblAppointmentDate.Text = appointment.Date.ToLocalTime().ToString("dd/MM/yyyy HH:mm") + ", " + appointment.Date.DayOfWeek.ToPortuguese();
            lblAppointmentStatus.Text = appointment.Status.ToPortuguese();

            mtbCustomerName.Text = appointment.Customer.Name;
            mtbCustomerEmail.Text = appointment.Customer.Email;
            mtbCustomerPhoneNumber.Text = appointment.Customer.PhoneNumber;

            mtbBarberName.Text = appointment.Barber.Name;
            mtbBarberEmail.Text = appointment.Barber.Email;
            mtbBarberPhoneNumber.Text = appointment.Barber.PhoneNumber;
            mtbBarberAddressCountry.Text = appointment.Barber.Address.Country;
            mtbBarberAddressState.Text = appointment.Barber.Address.State;
            mtbBarberAddressCity.Text = appointment.Barber.Address.City;
            mtbBarberAddress.Text = appointment.Barber.Address.Street + ", " + appointment.Barber.Address.Number;

            mtbServiceName.Text = appointment.Service.Name;
            mtbServiceDescription.Text = appointment.Service.Description;
            mtbServicePrice.Text = $"R$ {appointment.Service.Price.ToString("C2")}";
            mtbServiceDuration.Text = $"{appointment.Service.Duration.TotalMinutes} min";

            if (appointment.Status == Domain.Enums.AppointmentStatus.WaitingForAprovement)
            {
                btnCompleteAppointment.Enabled = false;
            }

            if (appointment.Status == Domain.Enums.AppointmentStatus.Canceled ||
                appointment.Status == Domain.Enums.AppointmentStatus.Completed)
            {
                btnCompleteAppointment.Enabled = false;
                btnCancelAppointment.Enabled = false;
            }

            if (!_sessionService.CurrentUserHasBarberProfile() ||
                _sessionService.GetCurrentUser()!.Id != appointment.Barber.Id)
            {
                btnCompleteAppointment.Enabled = false;
            }
        }

        private async void btnCompleteAppointment_Click(object sender, EventArgs e)
        {
            var command = new CompleteAppointmentCommand(
                _appointment.Id,
                _appointment.Barber.Id
            );

            var result = await _mediator.SendAsync(command);

            if (result.IsFailure)
            {
                MessageBox.Show($"Não foi possivel completar o agendamento, erro: {result.Error.Description}",
                    "Completar Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Agendamento finalizado com sucesso, ele estará inativo agora!",
                    "Completar Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            var command = new CancelAppointmentCommand(
                _appointment.Id,
                _appointment.Barber.Id,
                _appointment.Customer.Id
            );

            var result = await _mediator.SendAsync(command);

            if (result.IsFailure)
            {
                MessageBox.Show($"Não foi possivel cancelar o agendamento, erro: {result.Error.Description}",
                    "Cancelar Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"Agendamento cancelado com sucesso, ele estará inativo agora!",
                    "Cancelar Agendamento",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
