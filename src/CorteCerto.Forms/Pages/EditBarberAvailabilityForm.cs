using CorteCerto.App.Base;
using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.UseCases.Commands.Barbers;
using System.Globalization;

namespace CorteCerto.App.Pages
{
    public partial class EditBarberAvailabilityForm : BaseRegisterForm
    {
        private readonly ISessionService _sessionService;
        private readonly ICustomMediator _mediator;
        private readonly DayOfWeek Day;
        public (DateTime startTime, DateTime endTime) availabilityResult;  
        public EditBarberAvailabilityForm(ISessionService sessionService, ICustomMediator mediator, DayOfWeek day)
        {
            _sessionService = sessionService;
            _mediator = mediator;
            Day = day;

            InitializeComponent();

            btnSave.Location = new Point(150, 15);
            btnCancel.Location = new Point(295, 15);
        }

        protected override async void Save()
        {
            if(mtbStartTime.Text == "" || mtbEndTime.Text == "")
            {
                lblStartTimeError.Visible = true;
                lblEndTimeError.Visible = true;
                return;
            }

            var barberId = _sessionService.GetCurrentUser()!.Id;

            var startTime = DateTime.ParseExact(
                mtbStartTime.Text,
                new[] { "HH:mm", "H:mm" },
                CultureInfo.InvariantCulture
            );

            var endTime = DateTime.ParseExact(
               mtbEndTime.Text,
               new[] { "HH:mm", "H:mm" },
               CultureInfo.InvariantCulture
           );

            var command = new UpsertBarberAvailabilityCommand(barberId, Day, startTime, endTime);

            var result = await _mediator.SendAsync(command);

            if (result.IsFailure)
            {
                MessageBox.Show($"Erro ao editar disponibilidade para {Day.ToPortuguese()}.", "Editar Disponibilidade",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblStartTimeError.Visible = false;
                lblEndTimeError.Visible = false;

                MessageBox.Show($"Disponibilidade para {Day.ToPortuguese()} editada com sucesso!", "Editar Disponibilidade",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                var availability = result.Data.Availabilities.First(a => a.DayOfWeek == Day);

                availabilityResult = (availability.StartTime, availability.EndTime);

                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }
}
