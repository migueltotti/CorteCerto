using CorteCerto.App.Interfaces;
using CorteCerto.App.Models;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Domain.Helpers;
using LiteBus.Commands.Abstractions;
using ReaLTaiizor.Forms;
using System.Text.Json;
using Error = CorteCerto.Domain.Base.Error;

namespace CorteCerto.App.Pages
{
    public partial class CreateAccountForm : MaterialForm
    {
        #region Variables
        private readonly ICommandMediator _commandMediator;
        private readonly INavegationService _navegationService;
        private bool isPasswordVisible = false;
        #endregion

        #region Methods
        public CreateAccountForm(ICommandMediator commandMediator, INavegationService navegationService)
        {
            _commandMediator = commandMediator;
            _navegationService = navegationService;

            InitializeComponent();

            // Resolve problema do RealTaiizor iniciando o Forms um pouco deslocado para cima
            this.Load += (s, e) =>
            {
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            };

            // Adiciona Centralização do Painel de Login com base na largura e altura do Forms
            this.Load += (s, e) => CenterPanel();
            this.Resize += (s, e) => CenterPanel();
        }

        private void CenterPanel()
        {
            if (panel1 == null) return;

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private bool PasswordHasMinimumOrMaximumLength()
        {
            return 8 <= mtbPassword.Text.Length && mtbPassword.Text.Length <= 30;
        }

        private bool IsPasswordValid()
        {
            return PasswordHasMinimumOrMaximumLength() &&
                PasswordHelper.HasUpperAndLowerCaracter.IsMatch(mtbPassword.Text) &&
                PasswordHelper.HasNumber.IsMatch(mtbPassword.Text) &&
                PasswordHelper.HasSpecialCharacter.IsMatch(mtbPassword.Text);
        }

        private void ShowInputErrors(Error error)
        {
            if (error.Code.Contains("ValidationError"))
            {
                var validationErrors = JsonSerializer.Deserialize<List<ValidationErrorModel>>(error.Description);

                var firstError = validationErrors!.FirstOrDefault();

                if (firstError!.PropertyName!.Equals("Name"))
                {
                    lblNameError.Text = firstError.ErrorMessage;
                    lblNameError.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("Email"))
                {
                    lblEmailError.Text = firstError.ErrorMessage;
                    lblEmailError.Visible = true;
                }

                if (firstError!.PropertyName!.Equals("PhoneNumber"))
                {
                    lblPhoneError.Text = firstError.ErrorMessage;
                    lblPhoneError.Visible = true;
                }
            }
            else
            {
                MessageBox.Show(error.Description, "Erro ao criar conta.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Events
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            btnShowPassword.Icon = isPasswordVisible ?
                Properties.Resources.eye_slash :
                Properties.Resources.eye;

            mtbPassword.PasswordChar = isPasswordVisible ?
                new char[1].First() :
                '●';
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsPasswordValid())
            {
                lblNameError.Visible = false;
                lblEmailError.Visible = false;
                lblPhoneError.Visible = false;

                var command = new CreateAccountCommand(
                    mtbName.Text,
                    mtbEmail.Text,
                    mtbPassword.Text,
                    mtbPhoneNumber.Text.FormatPhoneNumber()
                );

                var result = await _commandMediator.SendAsync(command);

                if (result.IsFailure)
                {
                    ShowInputErrors(result.Error);
                }
                else
                {
                    MessageBox.Show("Conta criada com sucesso!", "Sucesso.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    _navegationService.NavegateTo<LoginForm>();
                    this.Close();
                }
            }
        }

        private void mtbLoginPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbPassword_TextChanged(object sender, EventArgs e)
        {
            lblLengthValidation.ForeColor = PasswordHasMinimumOrMaximumLength() ?
                Color.Green :
                Color.Red;

            lblCaseValidation.ForeColor = PasswordHelper.HasUpperAndLowerCaracter.IsMatch(mtbPassword.Text) ?
                Color.Green :
                Color.Red;

            lblNumberValidation.ForeColor = PasswordHelper.HasNumber.IsMatch(mtbPassword.Text) ?
                Color.Green :
                Color.Red;

            lblSpecialCharacterValidation.ForeColor = PasswordHelper.HasSpecialCharacter.IsMatch(mtbPassword.Text) ?
                Color.Green :
                Color.Red;
        }

        #endregion
    }
}
