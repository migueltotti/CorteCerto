using CorteCerto.App.Components;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Queries.Barbers;
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
        private readonly ICustomMediator _mediator;

        private readonly HashSet<DayOfWeek> _daysOfWeek = [
            DayOfWeek.Sunday,
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday
        ];
        #endregion

        #region Methods
        public MainForm(ICommandMediator commandMediator, IQueryMediator queryMediator, INavegationService navegationService, ISessionService sessionService, ICustomMediator mediator)
        {
            _navegationService = navegationService;
            _sessionService = sessionService;
            _mediator = mediator;

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
            btnBarberAvailabilities.ForeColor = Color.Black;
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

        private async Task LoadAvailabilityCards()
        {
            var barberId = _sessionService.GetCurrentUser()!.Id;

            var barber = (await _mediator.QueryAsync(new GetBarbersQuery(Id: barberId)))
                .Results.First();

            MaterialCard card;
            BarberAvailabilityDto? availability;

            int xLocaltionPoint = 17;
            int yLocaltionPoint = 143;
            const int padding = 20;

            foreach(var day in _daysOfWeek)
            {
                availability = barber.Availabilities.FirstOrDefault(a => a.DayOfWeek == day);

                card = BarberAvailabilityCard.Builder
                    .Create(day, _sessionService, _mediator)
                    .WithStartTime(availability?.StartTime ?? null)
                    .WithEndTime(availability?.EndTime ?? null)
                    .Build();

                card.Location = new Point(xLocaltionPoint, yLocaltionPoint);

                tabPageAvailability.Controls.Add(card);

                xLocaltionPoint += 270;

                if (xLocaltionPoint + card.Size.Width + padding > tabPageAvailability.Width)
                {
                    xLocaltionPoint = 17;
                    yLocaltionPoint += 266;
                }
            }
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
            tabControlMain.SelectedIndex = 3;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 4;
        }

        private void btnConfigurations_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 5;
        }

        private async void btnBarberAvailabilities_Click(object sender, EventArgs e)
        {
            if (_sessionService.IsAuthenticated && _sessionService.CurrentUserHasBarberProfile())
            {
                tabControlMain.SelectedIndex = 6;

                await LoadAvailabilityCards();
            }
            else
            {
                MessageBox.Show("Você precisa registrar um perfil de barbeiro para acessar esta seção.", "Acesso Negado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void mtbRegisterBarberProfile_Click(object sender, EventArgs e)
        {
            if (_sessionService.CurrentUserHasBarberProfile())
            {
                MessageBox.Show("Perfil de barbeiro já registrado!", "Perfil de Barbeiro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _navegationService.NavegateTo<RegisterBarberProfileForm>();
            }
        }
    }
}
