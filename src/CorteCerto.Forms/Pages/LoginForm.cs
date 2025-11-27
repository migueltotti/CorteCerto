using CorteCerto.App.Helpers;
using CorteCerto.App.Infra;
using CorteCerto.App.Pages;
using CorteCerto.Application.UseCases.Commands.People;
using LiteBus.Commands.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace CorteCerto.App
{
    public partial class LoginForm : MaterialForm
    {
        #region Variables
        private readonly ICommandMediator _commandMediator;
        private bool isPasswordVisible = false;
        #endregion

        #region Methods
        public LoginForm(ICommandMediator mediator)
        {
            _commandMediator = mediator;

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
        #endregion

        #region Events
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var result = await _commandMediator.SendAsync(new LoginCommand(mtbEmail.Text, mtbPassword.Text));

            if (result.IsFailure)
            {
                lblIncorrectEmail.Visible = true;
                lblIncorrectPassword.Visible = true;
            }

            NavegationHelper.NavegateTo<MainForm>();
            this.Hide();
        }

        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavegationHelper.NavegateTo<CreateAccountForm>();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            btnShowPassword.Icon = isPasswordVisible ? 
                Properties.Resources.eye_slash:
                Properties.Resources.eye;

            mtbPassword.PasswordChar = isPasswordVisible ?
                new char[1].First() :
                '●';
        }

        #endregion
    }
}
