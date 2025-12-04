using CorteCerto.App.Base;
using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Models;
using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Domain.Base;
using System.Globalization;
using System.Text.Json;

namespace CorteCerto.App.Pages
{
    public partial class RegisterBarberProfileForm : BaseRegisterForm
    {
        private readonly ICustomMediator _mediator;
        private readonly ISessionService _sessionService;

        public RegisterBarberProfileForm(ISessionService sessionService, ICustomMediator mediator)
        {
            _sessionService = sessionService;
            _mediator = mediator;

            InitializeComponent();

            btnCancel.Location = new Point(362, 18);
            btnSave.Location = new Point(224, 18);
        }

        protected override async void Save()
        {
            var currenteUser = _sessionService.GetCurrentUser();

            var command = new RegisterBarberProfileCommand(
                currenteUser!.Id,
                mtbDescription.Text,
                mtbPortifolioUrl.Text,
                mtbCep.Text.GetNumbers()!,
                int.Parse(mtbAddressNumber.Text.GetNumbers()!, CultureInfo.InvariantCulture)
            );

            var result = await _mediator.SendAsync(command);

            if (result.IsFailure)
            {
                ShowInputErrors(result.Error);
            }
            else
            {
                MessageBox.Show("Perfil de barbeiro criado com sucesso!", "Sucesso.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                _sessionService.ClearSession();
                _sessionService.SetSession(currenteUser, result.Data);

                this.Close();
            }
        }

        private bool IsFormValid()
        {
            return IsCepValid() &&
                !string.IsNullOrEmpty(mtbDescription.Text) &&
                !string.IsNullOrEmpty(mtbDescription.Text) &&
                IsAddressNumberValid();
        }

        private bool IsCepValid()
        {
            var cepNumbers = mtbCep.Text.GetNumbers();

            return !string.IsNullOrEmpty(cepNumbers) && cepNumbers.Length == 8;
        }

        private bool IsAddressNumberValid()
        {
            var addressNumber = mtbAddressNumber.Text.GetNumbers();

            return !string.IsNullOrEmpty(addressNumber);
        }

        private void ShowInputErrors(Error error)
        {
            if (error.Code.Contains("ValidationError"))
            {
                var validationErrors = JsonSerializer.Deserialize<List<ValidationErrorModel>>(error.Description);

                var firstError = validationErrors!.FirstOrDefault();

                if (firstError!.PropertyName!.Equals("Description"))
                {
                    lblDescriptionError.Text = firstError.ErrorMessage;
                    lblDescriptionError.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("Cep"))
                {
                    lblCepError.Text = firstError.ErrorMessage;
                    lblCepError.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("AddressNumber"))
                {
                    lblAddressNumberError.Text = firstError.ErrorMessage;
                    lblAddressNumberError.Visible = true;
                }
            }
            else
            {
                MessageBox.Show(error.Description, "Erro ao criar conta.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtbCep_Leave(object sender, EventArgs e)
        {
            var cep = mtbCep.Text.GetNumbers();

            if (!string.IsNullOrEmpty(cep) && cep.Length >= 8)
                mtbCep.Text = $"{cep.Substring(0, 2)}.{cep.Substring(2, 3)}-{cep.Substring(5, 3)}";
        }
    }
}
