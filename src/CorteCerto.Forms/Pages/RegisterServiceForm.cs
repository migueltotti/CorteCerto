using CorteCerto.App.Base;
using CorteCerto.App.Infra;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Models;
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
        private readonly ICustomMediator _mediator;
        private readonly ISessionService _sessionService;
        private readonly IQueryMediator _queryMediator;
        #endregion

        public RegisterServiceForm(ICustomMediator mediator, ISessionService sessionService)
        {
            _mediator = mediator;
            _sessionService = sessionService;

            InitializeComponent();
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
                //// TODO: Testar pra ver se isso funciona e se funcionar, criar um ICustomMediator para colocar tudo isso junto
                //// e não precisar fazer toda vez em todo lugar.
                //using var scope = ConfigureDI.serviceProvider.CreateScope();
                //_commandMediator = scope.ServiceProvider.GetRequiredService<ICommandMediator>();

                var command = new RegisterServiceCommand(
                    BarberId: _sessionService.GetCurrentCustomer()!.Id,
                    Name: mtbName.Text,
                    Description: mtbDescription.Text,
                    Price: decimal.Parse(mtbPrice.Text.Replace(",", ".")),
                    Duration: TimeSpan.FromMinutes(double.Parse(mtbDuration.Text))!
                );

                var result = await _mediator.SendAsync(command);

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
