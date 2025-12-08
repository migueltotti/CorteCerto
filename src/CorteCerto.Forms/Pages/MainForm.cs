using CorteCerto.App.Components;
using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.People;
using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Application.UseCases.Queries.Customers;
using CorteCerto.Application.UseCases.Queries.People;
using CorteCerto.Domain.Entities;
using CorteCerto.Domain.Filters;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private string _oldName = "";
        private string _oldEmail = "";
        private string _oldPhoneNumber = "";
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

            foreach (var day in _daysOfWeek)
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

        private async Task LoadServiceCards(
            string? name = null,
            TimeSpan? duration = null,
            decimal? price = null,
            PriceOperator priceOperator = default,
            DurationOperator durationOperator = default
        )
        {
            var query = new GetServicesQuery
            (
                Name: name,
                Duration: duration,
                Price: price,
                PriceOperator: priceOperator,
                DurationOperator: durationOperator
            );

            var services = await _mediator.QueryAsync(query);

            ServiceCard card;

            int xLocaltionPoint = 0;
            int yLocaltionPoint = 0;

            flpServiceCardList.Controls.Clear();

            foreach (var service in services.Results)
            {
                card = ServiceCard.Builder
                    .Create(_sessionService, _navegationService, _mediator)
                    .WithService(service)
                    .Build();

                card.Location = new Point(xLocaltionPoint, yLocaltionPoint);

                flpServiceCardList.Controls.Add(card);

                yLocaltionPoint += 131;
            }
        }

        private async Task LoadProfileInfo()
        {
            //var personId = _sessionService.GetCurrentUser()!.Id;
            var personId = Guid.Parse("c160437f-405c-4203-824f-033b827a089c");

            var customerResult = await _mediator.QueryAsync(new GetCustomersQuery(Id: personId));

            var customer = customerResult.Results.First();

            mtbProfileName.Text = customer.Name;
            mtbProfileEmail.Text = customer.Email;
            mtbProfilePhoneNumber.Text = customer.PhoneNumber;
            mtbProfilePromotionPoints.Text = customer.PromotionPoints.ToString();

            _oldName = customer.Name;
            _oldEmail = customer.Email;
            _oldPhoneNumber = customer.PhoneNumber;
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

        private async void btnServices_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;

            await LoadServiceCards();
        }

        private void btnBarbers_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 3;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 4;
        }

        private async void btnConfigurations_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 5;
            await LoadProfileInfo();
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

        private async void btnSearchServices_Click(object sender, EventArgs e)
        {
            await LoadServiceCards(
                name: mtbServiceName.Text != "" ? mtbServiceName.Text : null,
                duration: mtbDurationFilter.Text != "" ? TimeSpan.FromMinutes(Int32.Parse(mtbDurationFilter.Text)) : null,
                price: mtbPriceFilter.Text != "" ? Decimal.Parse(mtbPriceFilter.Text.Replace(",", ".")) : null,
                priceOperator: mcbPriceOperatorFilter.Text.ToPriceOperator(),
                durationOperator: mcbDurationOperatorFilter.Text.ToDurationOperator()
            );
        }

        private void mtbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void mtbFilter_TextChanged(object sender, EventArgs e)
        {
            var tb = (Control)sender as MaterialTextBoxEdit;

            if (tb == null)
                return;

            // Remove tudo que não for número
            tb.Text = new string(tb.Text.Where(char.IsDigit).ToArray());

            // Move o cursor para o final
            tb.SelectionStart = tb.Text.Length;
        }

        private async void btnApplyFilters_Click(object sender, EventArgs e)
        {
            await LoadServiceCards(
                name: mtbServiceName.Text != "" ? mtbServiceName.Text : null,
                duration: mtbDurationFilter.Text != "" ? TimeSpan.FromMinutes(Int32.Parse(mtbDurationFilter.Text)) : null,
                price: mtbPriceFilter.Text != "" ? Decimal.Parse(mtbPriceFilter.Text.Replace(",", ".")) : null,
                priceOperator: mcbPriceOperatorFilter.Text.ToPriceOperator(),
                durationOperator: mcbDurationOperatorFilter.Text.ToDurationOperator()
            );
        }

        private async void mtbServiceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                await LoadServiceCards(
                    name: mtbServiceName.Text != "" ? mtbServiceName.Text : null,
                    duration: mtbDurationFilter.Text != "" ? TimeSpan.FromMinutes(Int32.Parse(mtbDurationFilter.Text)) : null,
                    price: mtbPriceFilter.Text != "" ? Decimal.Parse(mtbPriceFilter.Text.Replace(",", ".")) : null,
                    priceOperator: mcbPriceOperatorFilter.Text.ToPriceOperator(),
                    durationOperator: mcbDurationOperatorFilter.Text.ToDurationOperator()
                );
            }
        }

        private void mtbPriceFilter_Leave(object sender, EventArgs e)
        {
            var price = mtbPriceFilter.Text.Replace(".", ",");

            if (!string.IsNullOrEmpty(price))
                mtbPriceFilter.Text = $"R$ {price}";
        }

        private async void btnSaveProfileChanges_Click(object sender, EventArgs e)
        {
            if (mtbProfileName.Text != "" && mtbProfileEmail.Text != "" && mtbProfilePhoneNumber.Text != "") 
            { 
                if (_oldEmail != mtbProfileEmail.Text)
                {
                    var updateEmailCommand = new UpdatePersonEmailCommand(
                        _sessionService.GetCurrentUser()!.Id,
                        _oldEmail,
                        mtbProfileEmail.Text
                    );

                    var emailResult = await _mediator.SendAsync(updateEmailCommand);

                    if (emailResult.IsFailure)
                    {
                        MessageBox.Show($"Não foi possivel atualizar o email, erro: {emailResult.Error.Description}", "Atualização de informações da conta.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if(_oldName != mtbProfileName.Text || _oldPhoneNumber != mtbProfilePhoneNumber.Text)
                {
                    var updateProfileInfo = new UpdateProfileInfoCommand(
                        _sessionService.GetCurrentUser()!.Id,
                        mtbProfileName.Text,
                        mtbProfilePhoneNumber.Text
                    );

                    var profileResult = await _mediator.SendAsync(updateProfileInfo);

                    if (profileResult.IsFailure)
                    {
                        MessageBox.Show($"Não foi possivel atualizar o nome ou o numero de telefone, erro: {profileResult.Error.Description}", "Atualização de informações da conta.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mtbProfileName.Text = profileResult.Data.Name;
                        mtbProfilePhoneNumber.Text = profileResult.Data.PhoneNumber;
                    }
                }

                mchbProfileEditMode.Checked = false;
            }
        }

        private void mchbProfileEditMode_CheckedChanged(object sender, EventArgs e)
        {
            mtbProfileName.Enabled = mchbProfileEditMode.Checked;
            mtbProfileName.ReadOnly = !mchbProfileEditMode.Checked;

            mtbProfileEmail.Enabled = mchbProfileEditMode.Checked;
            mtbProfileEmail.ReadOnly = !mchbProfileEditMode.Checked;

            mtbProfilePhoneNumber.Enabled = mchbProfileEditMode.Checked;
            mtbProfilePhoneNumber.ReadOnly = !mchbProfileEditMode.Checked;

            btnSaveProfileChanges.Enabled = mchbProfileEditMode.Checked;
        }
    }
}
