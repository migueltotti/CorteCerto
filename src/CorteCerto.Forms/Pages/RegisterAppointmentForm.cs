using CorteCerto.App.Base;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Models;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.Customers;
using CorteCerto.Application.UseCases.Queries.Barbers;
using CorteCerto.Application.UseCases.Queries.People;
using CorteCerto.Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ReaLTaiizor.Controls;

namespace CorteCerto.App.Pages
{
    public partial class RegisterAppointmentForm : BaseRegisterForm
    {
        #region Variables
        private readonly ICustomMediator _mediator;
        private readonly ISessionService _sessionService;

        private List<ServiceDto> _services = [];
        private List<BarberDto> _barbers = [];

        private int? _selectedServiceId = null;
        private Guid? _selectedBarberId = null;
        private DateTime? _selectedDate = null;
        private DateTime? _selectedDateTime = null;

        private int _lastSelectedTabIndex = 0;
        #endregion

        #region Methods
        public RegisterAppointmentForm(ICustomMediator mediator, ISessionService sessionService)
        {
            _mediator = mediator;
            _sessionService = sessionService;

            InitializeComponent();
        }

        public void InitializeWithServiceDto(ServiceDto service)
        {
            _selectedServiceId = service.Id;
            _selectedBarberId = service.Barber.Id;

            mtbServiceName.Text = service.Name;
            lblService.Text = mtbServiceName.Text;

            mtbBarberName.Text = service.Barber.Name;
            lblBarber.Text = mtbBarberName.Text;
        }

        private async Task LoadServicesGrid(string serviceName)
        {
            var query = string.IsNullOrEmpty(serviceName) ?
                new GetServicesQuery() :
                new GetServicesQuery(Name: serviceName);

            var result = await _mediator.QueryAsync(query);

            _services = result.Results.ToList();

            var formatedServices = _services.Adapt<List<ServiceModel>>();

            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = formatedServices;
            dataGridViewServices.Columns["Id"].Visible = false;
        }

        private async Task LoadBarbersGrid(string barberName)
        {
            var query = string.IsNullOrEmpty(barberName) ?
                new GetBarbersQuery() :
                new GetBarbersQuery(Name: barberName);

            var result = await _mediator.QueryAsync(query);

            _barbers = result.Results.ToList();

            dgwBarbers.DataSource = null;
            dgwBarbers.DataSource = _barbers;
            dgwBarbers.Columns["Id"].Visible = false;
            dgwBarbers.Columns["Email"].Visible = false;
        }


        private void ServiceGridToForm(DataGridViewRow? record)
        {
            _selectedServiceId = Convert.ToInt32(record?.Cells["Id"].Value);
            mtbServiceName.Text = record?.Cells["Name"].Value.ToString();
            lblService.Text = mtbServiceName.Text;

            var barber = _services.FirstOrDefault(s => s.Id == _selectedServiceId)?.Barber;

            _selectedBarberId = barber!.Id;
            mtbBarberName.Text = barber!.Name;
            lblBarber.Text = mtbBarberName.Text;
        }

        private void BarberGridToForm(DataGridViewRow? record)
        {
            _selectedBarberId = Guid.Parse(record?.Cells["Id"].Value.ToString()!);
            mtbBarberName2.Text = record?.Cells["Name"].Value.ToString();
            lblBarberName2.Text = mtbBarberName2.Text;

            var services = _services.FindAll(s => s.Barber.Id == _selectedBarberId);

            var formatedServices = services.Adapt<List<ServiceModel>>();

            dgwServices2.DataSource = null;
            dgwServices2.DataSource = formatedServices;
            dgwServices2.Columns["Id"].Visible = false;
        }

        private void BarberServiceGridToForm(DataGridViewRow? record)
        {
            _selectedServiceId = Convert.ToInt32(record?.Cells["Id"].Value);
            lblServiceName2.Text = record?.Cells["Name"].Value.ToString();
        }

        protected override async void Save()
        {
            if (_selectedServiceId is not null && _selectedBarberId is not null && _selectedDateTime is not null)
            {
                var command = new ScheduleBarberServiceCommand(
                    ServiceId: _selectedServiceId.Value,
                    CustomerId: _sessionService.GetCurrentUser()!.Id,
                    BarberId: _selectedBarberId.Value,
                    Date: _selectedDateTime.Value
                );

                var result = await _mediator.SendAsync(command);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Agendamento realizado com sucesso!", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    cbTimeAvailable.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Não foi possível realizar o agendamento: {result.Error.Description}", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Precisa selecionar um serviço e uma data para realizar o agendamento.", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GetAvailableTimeByDayOfWeek(DayOfWeek dayOfWeek, PoisonComboBox cb)
        {
            if (_selectedBarberId is not null)
            {
                cb.Items.Clear();

                var barber = _barbers.FirstOrDefault(s => s.Id == _selectedBarberId);

                var totalTimeAvailable = barber!.Availabilities.FirstOrDefault(a => a.DayOfWeek == dayOfWeek);

                if (totalTimeAvailable is null)
                {
                    cb.Items.Add("Barbeiro não está disponivel nessa data.");
                    cb.SelectedIndex = 0;
                    return;
                }

                for (var time = totalTimeAvailable.StartTime.TimeOfDay; time <= totalTimeAvailable.EndTime.TimeOfDay; time = time.Add(TimeSpan.FromMinutes(30)))
                {
                    cb.Items.Add(time);
                }

                cb.Enabled = true;
            }
            else
            {
                cb.Enabled = false;
            }
        }

        protected override void ClearFields()
        {
            _selectedServiceId = null;
            _selectedBarberId = null;
            _selectedDate = null;
            _selectedDateTime = null;

            mtbServiceName.Clear();
            mtbBarberName.Clear();
            cbTimeAvailable.Items.Clear();

            mtbBarberName2.Clear();
            dgwServices2.DataSource = null;
            cbAvailabilities.Items.Clear();

            lblService.Text = "";
            lblBarber.Text = "";
            lblDate.Text = "";

            lblServiceName2.Text = "";
            lblBarberName2.Text = "";
            lblDate2.Text = "";
        }
        #endregion

        #region Events
        // SERVICE TAB PAGE
        private async void btnSearchServices_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbServiceName.Text))
            {
                await LoadServicesGrid(mtbServiceName.Text);
            }
        }

        private void dataGridViewServices_DoubleClick(object sender, EventArgs e)
        {
            var record = dataGridViewServices.SelectedRows[0];
            ServiceGridToForm(record);
        }

        private async void mtbServiceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(mtbServiceName.Text))
            {
                await LoadServicesGrid(mtbServiceName.Text);
            }
        }

        private void dpAppointmentDate_onDateChanged(DateTime newDateTime)
        {
            var date = dpAppointmentDate.Date;

            _selectedDate = date;

            GetAvailableTimeByDayOfWeek(date.DayOfWeek, cbTimeAvailable);
        }

        private void cbTimeAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimeAvailable.SelectedItem!.ToString() == "Barbeiro não está disponivel nessa data." ||
                cbTimeAvailable.SelectedItem!.ToString() == "")
            {
                lblDate.Text = "";
                return;
            }

            var time = cbTimeAvailable.SelectedItem!.ToString();
            var date = _selectedDate!.Value.Date;

            var timeSpan = TimeSpan.Parse(time);

            var dateTime = date + timeSpan;

            _selectedDateTime = dateTime;
            lblDate.Text = _selectedDateTime.Value.ToString("dd/MM/yyyy HH:mm");
        }

        private async void RegisterAppointmentForm_Load(object sender, EventArgs e)
        {
            await LoadServicesGrid(string.Empty);
            await LoadBarbersGrid(string.Empty);
        }

        // BARBER TAB PAGE

        private async void mtbBarberSearch2_Click(object sender, EventArgs e)
        {
            await LoadBarbersGrid(mtbBarberName2.Text);
        }

        private void cbAvailabilities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAvailabilities.SelectedItem!.ToString() == "Barbeiro não está disponivel nessa data." ||
                cbAvailabilities.SelectedItem!.ToString() == "")
            {
                lblDate2.Text = "";
                return;
            }

            var time = cbAvailabilities.SelectedItem!.ToString();
            var date = _selectedDate!.Value.Date;

            var timeSpan = TimeSpan.Parse(time);

            var dateTime = date + timeSpan;

            _selectedDateTime = dateTime;
            lblDate2.Text = _selectedDateTime.Value.ToString("dd/MM/yyyy HH:mm");
        }

        private void dpDate2_onDateChanged(DateTime newDateTime)
        {
            var date = dpDate2.Date;

            _selectedDate = date;

            GetAvailableTimeByDayOfWeek(date.DayOfWeek, cbAvailabilities);
        }

        private async void mtbBarberName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(mtbBarberName2.Text))
            {
                await LoadBarbersGrid(mtbBarberName2.Text);
            }
        }

        private async void dgwBarbers_DoubleClick(object sender, EventArgs e)
        {
            var record = dgwBarbers.SelectedRows[0];
            BarberGridToForm(record);
        }

        private void dgwServices2_DoubleClick(object sender, EventArgs e)
        {
            var record = dgwServices2.SelectedRows[0];
            BarberServiceGridToForm(record);
        }

        private async void tabPageService_Enter(object sender, EventArgs e)
        {
            if (_lastSelectedTabIndex != 0)
            {
                _lastSelectedTabIndex = 0;
                ClearFields();
                await LoadServicesGrid(string.Empty);
                await LoadBarbersGrid(string.Empty);
            }
        }

        private async void tabPageBarber_Enter(object sender, EventArgs e)
        {
            _lastSelectedTabIndex = 1;
            ClearFields();
            await LoadServicesGrid(string.Empty);
            await LoadBarbersGrid(string.Empty);
        }

        #endregion
    }
}
