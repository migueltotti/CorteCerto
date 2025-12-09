using CorteCerto.App.Helpers;
using CorteCerto.Application.DTO;
using ReaLTaiizor.Forms;

namespace CorteCerto.App.Pages
{
    public partial class AppointmentInfoForm : MaterialForm
    {
        public AppointmentInfoForm()
        {
            InitializeComponent();
        }

        public void InitializeWithAppointmentDto(AppointmentDto appointment)
        {
            lblAppointmentDate.Text = appointment.Date.ToLocalTime().ToString("dd/MM/yyyy HH:mm") + ", "+ appointment.Date.DayOfWeek.ToPortuguese();

            mtbCustomerName.Text = appointment.Customer.Name;
            mtbCustomerEmail.Text = appointment.Customer.Email;
            mtbCustomerPhoneNumber.Text = appointment.Customer.PhoneNumber;

            mtbBarberName.Text = appointment.Barber.Name;
            mtbBarberEmail.Text = appointment.Barber.Email;
            mtbBarberPhoneNumber.Text = appointment.Barber.PhoneNumber;
            mtbBarberAddressCountry.Text = appointment.Barber.Address.Country;
            mtbBarberAddressState.Text = appointment.Barber.Address.State;
            mtbBarberAddressCity.Text = appointment.Barber.Address.City;
            mtbBarberAddress.Text = appointment.Barber.Address.Street + ", " + appointment.Barber.Address.Number;

            mtbServiceName.Text = appointment.Service.Name;
            mtbServiceDescription.Text = appointment.Service.Description;
            mtbServicePrice.Text = $"R$ {appointment.Service.Price.ToString("C2")}";
            mtbServiceDuration.Text = $"{appointment.Service.Duration.TotalMinutes} min";
        }
    }
}
