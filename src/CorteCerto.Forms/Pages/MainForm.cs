using CorteCerto.App.Components;
using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.Barbers;
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
using System.Runtime.ConstrainedExecution;
using System.Threading;
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

        private string _oldDescription = "";
        private string _oldPortifolioUrl = "";
        private string _oldCep = "";
        private string _oldAddressNumber = "";
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

            AjustFLPAppointmentRequestsPosition();
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

        private void AjustFLPAppointmentRequestsPosition()
        {
            label45.Location = new Point(
                17,
                flpAppointmentRequest.Location.Y + 252
            );

            flpAppointmentRequest.Location = new Point(
                17,
                flpAppointmentRequest.Location.Y + 292
            );
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
            var personId = _sessionService.GetCurrentUser()!.Id;

            var customerResult = await _mediator.QueryAsync(new GetCustomersQuery(Id: personId));

            var customer = customerResult.Results.First();

            mtbProfileName.Text = customer.Name;
            mtbProfileEmail.Text = customer.Email;
            mtbProfilePhoneNumber.Text = customer.PhoneNumber;
            mtbProfilePromotionPoints.Text = customer.PromotionPoints.ToString();

            _oldName = customer.Name;
            _oldEmail = customer.Email;
            _oldPhoneNumber = customer.PhoneNumber;

            if (_sessionService.CurrentUserHasBarberProfile())
            {
                var barberResult = await _mediator.QueryAsync(new GetBarbersQuery(Id: personId));

                var barber = barberResult.Results.First();

                var cep = barber.Address.ZipCode;

                mrtbBarberDescription.Text = barber.Description;
                mtbBarberPortifolioUrl.Text = barber.PortfolioUrl;
                mtbBarberCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
                mtbBarberAddressNumber.Text = barber.Address.Number.ToString();

                mtbBarberAddressCountry.Text = barber.Address.Country;
                mtbBarberAddressState.Text = barber.Address.State;
                mtbBarberAddressCity.Text = barber.Address.City;
                mtbBarberAddress.Text = barber.Address.Street;

                _oldDescription = barber.Description;
                _oldPortifolioUrl = barber.PortfolioUrl;
                _oldCep = barber.Address.ZipCode;
                _oldAddressNumber = barber.Address.Number.ToString();
            }
        }

        private async Task LoadAppointmentRequestsCards()
        {
            //var barberId = _sessionService.GetCurrentUser()!.Id;
            var barberId = Guid.Parse("c160437f-405c-4203-824f-033b827a089c");

            var appointments = await _mediator.QueryAsync(new GetAppointmentsQuery(
                BarberId: barberId, 
                AppointmentStatus: Domain.Enums.AppointmentStatus.WaitingForAprovement
            ));

            AppointmentRequestCard card;

            int xLocaltionPoint = 14;
            int yLocaltionPoint = 14;
            const int padding = 10;

            foreach (var appointmentRequest in appointments.Results)
            {
                card = AppointmentRequestCard.Builder
                    .Create(_mediator)
                    .WithAppointment(appointmentRequest)
                    .Build();

                card.Location = new Point(xLocaltionPoint, yLocaltionPoint);

                flpAppointmentRequest.Controls.Add(card);

                xLocaltionPoint += 218 + padding;
            }
        }

        private bool HasProfileChanges()
        {
            return
                _oldName != mtbProfileName.Text ||
                _oldPhoneNumber != mtbProfilePhoneNumber.Text;
        }

        private bool HasProfileEmailChanged()
        {
            return _oldEmail != mtbProfileEmail.Text;
        }

        private bool HasBarberProfileChanges()
        {
            return
                _oldDescription != mrtbBarberDescription.Text ||
                _oldPortifolioUrl != mtbBarberPortifolioUrl.Text ||
                _oldCep != mtbBarberCep.Text ||
                _oldAddressNumber != mtbBarberAddressNumber.Text;
        }

        private bool IsProfileInfoValid()
        {
            return
                mtbProfileName.Text != "" &&
                mtbProfileEmail.Text != "" &&
                mtbProfilePhoneNumber.Text != "";
        }

        private bool IsBarberInfoValid()
        {
            return
                mrtbBarberDescription.Text != "" &&
                mtbBarberCep.Text != "" &&
                mtbBarberAddressNumber.Text != "";
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

        private async void btnUserAction_Click(object sender, EventArgs e)
        {
            if (_sessionService.IsAuthenticated)
            {
                tabControlMain.SelectedIndex = 5;
                await LoadProfileInfo();
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

        private async void btnAppoitments_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;

            await LoadAppointmentRequestsCards();
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
            if (_sessionService.IsAuthenticated)
            {
                tabControlMain.SelectedIndex = 5;
                await LoadProfileInfo();
            }
            else
            {
                MessageBox.Show("Você precisa fazer login para acessar esta seção.", "Acesso Negado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (IsProfileInfoValid())
            {
                if (HasProfileEmailChanged())
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

                    _oldEmail = mtbProfileEmail.Text;
                }

                if (HasProfileChanges())
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

                        _oldName = profileResult.Data.Name;
                        _oldPhoneNumber = profileResult.Data.PhoneNumber;
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

        private void mchbBarberEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if (_sessionService.CurrentUserHasBarberProfile())
            {
                mrtbBarberDescription.ReadOnly = !mchbBarberEditMode.Checked;

                mtbBarberPortifolioUrl.Enabled = mchbBarberEditMode.Checked;
                mtbBarberPortifolioUrl.ReadOnly = !mchbBarberEditMode.Checked;

                mtbBarberCep.Enabled = mchbBarberEditMode.Checked;
                mtbBarberCep.ReadOnly = !mchbBarberEditMode.Checked;

                mtbBarberAddressNumber.Enabled = mchbBarberEditMode.Checked;
                mtbBarberAddressNumber.ReadOnly = !mchbBarberEditMode.Checked;

                btnSaveBarberChanges.Enabled = mchbBarberEditMode.Checked;
            }
            else
            {
                mchbBarberEditMode.Checked = false;
            }
        }

        private async void btnSaveBarberChanges_Click(object sender, EventArgs e)
        {
            if (IsBarberInfoValid() && HasBarberProfileChanges())
            {
                var updateBarberInfo = new UpdateBarberProfileCommand(
                    _sessionService.GetCurrentUser()!.Id,
                    mtbProfileName.Text,
                    mrtbBarberDescription.Text,
                    mtbBarberPortifolioUrl.Text != "" ? mtbBarberPortifolioUrl.Text : null,
                    mtbProfilePhoneNumber.Text,
                    mtbBarberCep.Text,
                    Int32.Parse(mtbBarberAddressNumber.Text)
                );

                var barberResult = await _mediator.SendAsync(updateBarberInfo);

                if (barberResult.IsFailure)
                {
                    MessageBox.Show($"Não foi possivel atualizar descrição, portifolio, cep ou numero de endereço do barbeiro, erro: {barberResult.Error.Description}", "Atualização de informações da conta.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var cep = barberResult.Data.Address.ZipCode;

                    mrtbBarberDescription.Text = barberResult.Data.Description;
                    mtbBarberPortifolioUrl.Text = barberResult.Data.PortfolioUrl;
                    mtbBarberCep.Text = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
                    mtbBarberAddressNumber.Text = barberResult.Data.Address.Number.ToString();

                    mtbBarberAddressCountry.Text = barberResult.Data.Address.Country;
                    mtbBarberAddressState.Text = barberResult.Data.Address.State;
                    mtbBarberAddressCity.Text = barberResult.Data.Address.City;
                    mtbBarberAddress.Text = barberResult.Data.Address.Street;

                    _oldDescription = barberResult.Data.Description;
                    _oldPortifolioUrl = barberResult.Data.PortfolioUrl;
                    _oldCep = $"{cep.Substring(0, 5)}-{cep.Substring(5, 3)}";
                    _oldAddressNumber = barberResult.Data.Address.Number.ToString();
                }

                mchbBarberEditMode.Checked = false;
            }
        }
    }
}
