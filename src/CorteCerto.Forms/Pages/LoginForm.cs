using CorteCerto.App.Interfaces;
using CorteCerto.App.Pages;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Application.UseCases.Queries.Customers;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Mapster;
using ReaLTaiizor.Forms;

namespace CorteCerto.App
{
    public partial class LoginForm : MaterialForm
    {
        #region Variables
        private readonly ICustomMediator _mediator;
        private readonly INavegationService _navegationService;
        private readonly ISessionService _sessionService;
        private bool isPasswordVisible = false;
        #endregion

        #region Methods
        public LoginForm(ICustomMediator mediator, INavegationService navegationService, ISessionService sessionService)
        {
            _mediator = mediator;
            _navegationService = navegationService;
            _sessionService = sessionService;

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
            var result = await _mediator.SendAsync(new LoginCommand(mtbEmail.Text, mtbPassword.Text));

            if (result.IsFailure)
            {
                lblIncorrectEmail.Visible = true;
                lblIncorrectPassword.Visible = true;
            }
            else
            {
                var customer = await _mediator.QueryAsync(new GetCustomersQuery(null, null, mtbEmail.Text));

                _sessionService.SetSession(customer.Results.First());
                _navegationService.NavegateTo<MainForm>();
                this.Close();
            }
        }

        private void lblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _navegationService.NavegateTo<CreateAccountForm>();
            this.Close();
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
