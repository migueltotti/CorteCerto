using CorteCerto.App.Base;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.UseCases.Commands.Barbers;
using LiteBus.Commands.Abstractions;

namespace CorteCerto.App.Pages
{
    public partial class RegisterServiceForm : BaseRegisterForm
    {
        #region Variables
        private readonly ICommandMediator _commandMediator;
        private readonly ISessionService _sessionService;
        #endregion

        public RegisterServiceForm(ICommandMediator commandMediator, ISessionService sessionService)
        {
            _commandMediator = commandMediator;
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
                var command = new RegisterServiceCommand(
                    BarberId: _sessionService.GetCurrentCustomer()!.Id,
                    Name: mtbName.Text,
                    Description: mtbDescription.Text,
                    Price: decimal.Parse(mtbPrice.Text.Replace(",", ".")),
                    Duration: TimeSpan.FromMinutes(double.Parse(mtbDuration.Text))!
                );

                var result = await _commandMediator.SendAsync(command);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Serviço registrado com sucesso!", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
                else
                {
                    MessageBox.Show($"Não foi possível registrar o serviço: {result.Error.Description}", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
