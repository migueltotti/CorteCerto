using CorteCerto.App.Base;
using CorteCerto.App.Infra;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Models;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.Barbers;
using CorteCerto.Domain.Base;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace CorteCerto.App.Pages
{
    public partial class RegisterServiceForm : BaseRegisterForm
    {
        #region Variables
        private bool _isEditMode = false;
        private int? _serviceId = null;
        private readonly ICustomMediator _mediator;
        private readonly ISessionService _sessionService;
        #endregion

        public RegisterServiceForm(ICustomMediator mediator, ISessionService sessionService)
        {
            _mediator = mediator;
            _sessionService = sessionService;

            InitializeComponent();
        }

        public void InitializeForEditMode(ServiceDto service)
        {
            _isEditMode = true;
            _serviceId = service.Id;
            Text = "Editar Serviço";
            btnSave.Text = "Salvar";
            mtbName.Text = service.Name;
            mtbDescription.Text = service.Description;
            mtbPrice.Text = service.Price.ToString("F2");
            mtbDuration.Text = service.Duration.TotalMinutes.ToString();
        }

        protected override async void Save()
        {
            if (mtbName.Text == "" || mtbDescription.Text == "" || mtbPrice.Text == "" || mtbDuration.Text == "")
            {
                MessageBox.Show("Campos obrigatórios dever ser preenchidos para registrar o serviço.", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Result<ServiceDto> result;

                if (_isEditMode)
                {
                    var editCommand = new UpdateServiceCommand(
                        BarberId: _sessionService.GetCurrentUser()!.Id,
                        ServiceId: _serviceId!.Value,
                        Name: mtbName.Text,
                        Description: mtbDescription.Text,
                        Price: decimal.Parse(mtbPrice.Text.Replace(",", ".")),
                        Duration: TimeSpan.FromMinutes(double.Parse(mtbDuration.Text))!,
                        IsAvailable: true
                    );

                    result = await _mediator.SendAsync(editCommand);
                }
                else
                {

                    var command = new RegisterServiceCommand(
                        BarberId: _sessionService.GetCurrentUser()!.Id,
                        Name: mtbName.Text,
                        Description: mtbDescription.Text,
                        Price: decimal.Parse(mtbPrice.Text.Replace(",", ".")),
                        Duration: TimeSpan.FromMinutes(double.Parse(mtbDuration.Text))!
                    );

                    result = await _mediator.SendAsync(command);
                }

                if (result.IsSuccess)
                {
                    MessageBox.Show("Serviço registrado com sucesso!", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
                else
                {
                    ShowInputErrors(result.Error);
                }
            }
        }

        private void ShowInputErrors(Error error)
        {
            if (error.Code.Contains("ValidationError"))
            {
                var validationErrors = JsonSerializer.Deserialize<List<ValidationErrorModel>>(error.Description);

                var firstError = validationErrors!.FirstOrDefault();

                if (firstError!.PropertyName!.Equals("Name"))
                {
                    lblIncorrectName.Text = firstError.ErrorMessage;
                    lblIncorrectName.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("Description"))
                {
                    lblIncorrectDescription.Text = firstError.ErrorMessage;
                    lblIncorrectDescription.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("Price"))
                {
                    lblIncorrectPrice.Text = firstError.ErrorMessage;
                    lblIncorrectPrice.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("Duration"))
                {
                    lblIncorrectDuration.Text = firstError.ErrorMessage;
                    lblIncorrectDuration.Visible = true;
                }
            }
            else
            {
                MessageBox.Show($"Não foi possível registrar o serviço: {error.Description}", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void ClearFields()
        {
            mtbName.Text = "";
            mtbDescription.Text = "";
            mtbPrice.Text = "";
            mtbDuration.Text = "";
        }
    }
}
