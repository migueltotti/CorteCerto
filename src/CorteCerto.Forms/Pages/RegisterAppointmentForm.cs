using CorteCerto.App.Base;
using CorteCerto.Application.DTO;
using CorteCerto.Application.UseCases.Queries.People;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;

namespace CorteCerto.App.Pages
{
    public partial class RegisterAppointmentForm : BaseRegisterForm
    {
        #region Variables
        private readonly ICommandMediator _commandMediator;
        private readonly IQueryMediator _queryMediator;

        private List<ServiceDto> _services = [];
        private List<BarberDto> _barbers = [];
        #endregion

        #region Methods
        public RegisterAppointmentForm(ICommandMediator commandMediator, IQueryMediator queryMediator)
        {
            InitializeComponent();
            _commandMediator = commandMediator;
            _queryMediator = queryMediator;
        }

        private async Task UpdateServicesGrid(string serviceName)
        {
            var query = new GetServicesQuery(Name: serviceName);

            var result = await _queryMediator.QueryAsync(query);

            _services = result.Results.ToList();

            dataGridViewServices.DataSource = null;
            dataGridViewServices.DataSource = _services;
            dataGridViewServices.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void GridToForm(DataGridViewRow? record)
        {
            mtbId.Text = record?.Cells["Id"].Value.ToString();
            mtbName.Text = record?.Cells["Name"].Value.ToString();
            mtbDescription.Text = record?.Cells["Description"].Value.ToString();
        }
        #endregion

        private async void tabPageService_Enter(object sender, EventArgs e)
        {
            var result = await _queryMediator.QueryAsync(new GetServicesQuery());

            _services = result.Results.ToList();

            dataGridViewServices.DataSource = _services;
            dataGridViewServices.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private async void btnSearchServices_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(mtbServiceName.Text))
            {
                await UpdateServicesGrid(mtbServiceName.Text);
            }
        }

        private void dataGridViewServices_DoubleClick(object sender, EventArgs e)
        {
            var record = dataGridViewServices.SelectedRows[0];
            GridToForm(record);
        }
    }
}
