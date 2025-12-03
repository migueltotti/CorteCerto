using CorteCerto.App.Interfaces;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace CorteCerto.App.Pages
{
    public partial class MainForm : MaterialForm
    {
        #region Variables
        private readonly INavegationService _navegationService;
        private readonly ISessionService _sessionService;
        #endregion

        #region Methods
        public MainForm(ICommandMediator commandMediator, IQueryMediator queryMediator, INavegationService navegationService, ISessionService sessionService)
        {
            _navegationService = navegationService;
            _sessionService = sessionService;

            InitializeComponent();

            HideTabPageTitles();

            // Resolve problema do RealTaiizor iniciando o Forms um pouco deslocado para cima
            this.Load += (s, e) =>
            {
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            };
        }

        private void ColorSideBarButtons()
        {
            btnDashboard.ForeColor = Color.Black;
            btnAppoitments.ForeColor = Color.Black;
            btnServices.ForeColor = Color.Black;
            btnBarbers.ForeColor = Color.Black;
            btnReports.ForeColor = Color.Black;
            btnConfigurations.ForeColor = Color.Black;
        }

        private void HideTabPageTitles()
        {
            tabControlMain.Appearance = TabAppearance.FlatButtons;
            tabControlMain.ItemSize = new Size(0, 1);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
        }

        private void SetUserInfo()
        {
            if (_sessionService.IsAuthenticated)
            {
                lblUserName.Text = _sessionService.GetUserName();
                lblUserEmail.Text = _sessionService.GetUserEmail();

                btnUserAction.Text = "Profile";
            }
            else
            {
                btnUserAction.Text = "Login";
            }
        }

        private void LogoutUser()
        {
            lblUserName.Text = "Nome Usuário";
            lblUserEmail.Text = "nome@gmail.com";

            btnUserAction.Text = "Login";

            _sessionService.ClearSession();
        }
        #endregion

        #region Events

        private void MainForm_Load(object sender, EventArgs e)
        {
            ColorSideBarButtons();
            SetUserInfo();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutUser();
        }

        private void btnUserAction_Click(object sender, EventArgs e)
        {
            if (_sessionService.IsAuthenticated)
            {

            }
            else
            {
                _navegationService.NavegateTo<LoginForm>();
                this.Hide();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }

        private void btnAppoitments_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
        }

        private void btnBarbers_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 4;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 5;
        }

        private void btnConfigurations_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 7;
        }

        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            _navegationService.NavegateTo<RegisterAppointmentForm>();
        }

        private void btnDashboardNewAppointment_Click(object sender, EventArgs e)
        {
            _navegationService.NavegateTo<RegisterAppointmentForm>();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void btnDashboardNewService_Click(object sender, EventArgs e)
        {
            _navegationService.NavegateTo<RegisterServiceForm>();
        }

        #endregion
    }
}
