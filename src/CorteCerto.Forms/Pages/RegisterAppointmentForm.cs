using CorteCerto.App.Base;
using CorteCerto.App.Interfaces;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Commands.Customers;
using CorteCerto.Application.UseCases.Queries.People;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace CorteCerto.App.Pages
{
    public partial class RegisterAppointmentForm : BaseRegisterForm
    {
        #region Variables
        private readonly ICommandMediator _commandMediator;
        private readonly IQueryMediator _queryMediator;
        private readonly ISessionService _sessionService;

        private List<ServiceDto> _services = [];
        private List<BarberDto> _barbers = [];

        private int? _selectedServiceId = null;
        private Guid? _selectedBarberId = null;
        private DateTime? _selectedDate = null;
        private DateTime? _selectedDateTime = null;
        #endregion

        #region Methods
        public RegisterAppointmentForm(ICommandMediator commandMediator, IQueryMediator queryMediator, ISessionService sessionService)
        {
            _commandMediator = commandMediator;
            _queryMediator = queryMediator;
            _sessionService = sessionService;

            InitializeComponent();
        }

        private async Task LoadServicesGrid(string serviceName)
        {
            var query = string.IsNullOrEmpty(serviceName) ?
                new GetServicesQuery() :
                new GetServicesQuery(Name: serviceName);

            var result = await _queryMediator.QueryAsync(query);

            _services = result.Results.ToList();

            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = _services;
            dataGridViewServices.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        protected override async void Save()
        {
            if (_selectedServiceId is null || _selectedBarberId is null || _selectedDateTime is null)
            {
                MessageBox.Show("Precisa selecionar um serviço e uma data para realizar o agendamento.", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var command = new ScheduleBarberServiceCommand(
                    ServiceId: _selectedServiceId.Value,
                    CustomerId: _sessionService.GetCurrentCustomer()!.Id,
                    BarberId: _selectedBarberId.Value,
                    Date: _selectedDate.Value
                );

                var result = await _commandMediator.SendAsync(command);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Agendamento realizado com sucesso!", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
                else
                {
                    MessageBox.Show($"Não foi possível realizar o agendamento: {result.Error.Description}", "Corte Certo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetAvailableTimeByDayOfWeek(DayOfWeek dayOfWeek)
        {
            if (_selectedBarberId is not null)
            {
                cbTimeAvailable.Items.Clear();

                var barber = _services.FirstOrDefault(s => s.Id == _selectedServiceId)?.Barber;

                var totalTimeAvailable = barber!.Availabilities.FirstOrDefault(a => a.DayOfWeek == dayOfWeek);

                if(totalTimeAvailable is null)
                {
                    cbTimeAvailable.Items.Add("Barbeiro não está disponivel nessa data.");
                    cbTimeAvailable.SelectedIndex = 0;
                    return;
                }

                cbTimeAvailable.Items.Add("");

                for (var time = totalTimeAvailable.StartTime.TimeOfDay; time <= totalTimeAvailable.EndTime.TimeOfDay; time = time.Add(TimeSpan.FromHours(1)))
                {
                    cbTimeAvailable.Items.Add(time);
                }

                cbTimeAvailable.Enabled = true;
            }
            else
            {
                cbTimeAvailable.Enabled = false;
            }
        }
        #endregion

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

            GetAvailableTimeByDayOfWeek(date.DayOfWeek);
        }

        private void cbTimeAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {
            var time = cbTimeAvailable.SelectedItem.ToString();

            var dateTime = DateTime.Parse($"{_selectedDate.Value.Date.Date} {time}");

            _selectedDateTime = dateTime;

            lblDate.Text = _selectedDateTime.ToString();
        }

        private async void RegisterAppointmentForm_Load(object sender, EventArgs e)
        {
            await LoadServicesGrid(string.Empty);
        }
    }
}
