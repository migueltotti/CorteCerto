using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Pages;
using CorteCerto.Application.DTO;
using CorteCerto.Domain.Entities;
using ReaLTaiizor.Controls;
using CheckBox = System.Windows.Forms.CheckBox;

namespace CorteCerto.App.Components;

internal class AppointmentRequestCard : MaterialCard
{
    #region Variables
    public AppointmentDto Appointment { get; set; }
    public bool IsSelected { get; set; } = false;

    private readonly INavegationService _navegationService;
    #endregion

    #region Methods
    private AppointmentRequestCard(INavegationService navegationService)
    {
        _navegationService = navegationService;
    }

    private void AddEventClickShowMoreInfoButton()
    {
        foreach (var control in Controls)
        {
            if (control is MaterialButton btn && btn.Name == $"btnShowMoreInfo-{Appointment.Id}")
            {
                btn.Click += BtnShowMoreInfo_Click;
                break;
            }
        }
    }

    private void AddEventCheckedChangedIsAppointmentSelectedCheckBox()
    {
        foreach (var control in Controls)
        {
            if (control is CheckBox chb && chb.Name == $"chbIsAppointmentSelected-{Appointment.Id}")
            {
                chb.CheckedChanged += chbIsAppointmentSelected_CheckedChanged;
                break;
            }
        }
    }
    #endregion

    #region Events
    private void BtnShowMoreInfo_Click(object? sender, EventArgs e)
    {
        _navegationService.NavegateTo<AppointmentInfoForm>(initializer: init =>
            init.InitializeWithAppointmentDto(Appointment));
    }

    private void chbIsAppointmentSelected_CheckedChanged(object sender, EventArgs e)
    {
        IsSelected = !IsSelected;
    }

    #endregion

    #region Builder Class
    public class Builder()
    {
        private INavegationService _navegationService;
        private AppointmentDto _appointment;

        public static Builder Create(INavegationService navegationService)
        {
            var builder = new Builder()
            {
                _navegationService = navegationService
            };

            return builder;
        }
        public Builder WithAppointment(AppointmentDto appointment)
        {
            _appointment = appointment;
            return this;
        }

        private Label CreateCustomerNameTitle()
        {
            var splitCustomerName = _appointment.Customer.Name.Split(" ");

            var firtsName = splitCustomerName[0];
            var secondName = splitCustomerName.Length > 1 ? splitCustomerName[1] : string.Empty;

            return new Label
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(10, 14),
                Name = $"lblCustomerName-{_appointment.Id}",
                Size = new Size(168, 32),
                TabIndex = 35,
                Text = $"{firtsName} {secondName}"
            };
        }

        private CheckBox CreateConfirmAppointmentCheckBox()
        {
            return new CheckBox
            {
                AutoSize = true,
                Location = new Point(184, 17),
                Name = $"chbIsAppointmentSelected-{_appointment.Id}",
                Size = new Size(18, 17),
                TabIndex = 40,
                UseVisualStyleBackColor = true,
                Checked = false
            };
        }

        private (Label date, Label time) CreateDateAndTimeLabels()
        {
            var lblDate = new Label
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(10, 46),
                Name = $"lblDate-{_appointment.Id}",
                Size = new Size(101, 24),
                TabIndex = 36,
                Text = _appointment.Date.ToString("dd/MM/yyyy")
            };

            var lblTime = new Label()
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(10, 67),
                Name = $"lblTime-{_appointment.Id}",
                Size = new Size(101, 24),
                TabIndex = 37,
                Text = _appointment.Date.ToLocalTime().ToString("HH:mm")
            };

            return (lblDate, lblTime);
        }

        private Label CreateWeekDay()
        {
            return new Label
            {
                Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(117, 55),
                Name = $"lblWeekDay-{_appointment.Id}",
                Size = new Size(94, 24),
                TabIndex = 38,
                Text = _appointment.Date.DayOfWeek.ToPortuguese()
            };
        }

        private Label CreateServiceName()
        {
            return new Label
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Location = new Point(10, 97),
                Name = $"lblServiceName-{_appointment.Id}",
                Size = new Size(201, 65),
                TabIndex = 35,
                Text = _appointment.Service.Name
            };
        }

        private MaterialButton CreateShowMoreInfoButton()
        {
            return new MaterialButton
            {
                AutoSize = false,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Density = MaterialButton.MaterialButtonDensity.Default,
                Depth = 0,
                HighEmphasis = true,
                Icon = null,
                IconType = MaterialButton.MaterialIconType.Rebase,
                Location = new Point(10, 166),
                Margin = new Padding(4, 6, 4, 6),
                MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER,
                Name = $"btnShowMoreInfo-{_appointment.Id}",
                NoAccentTextColor = Color.Empty,
                Size = new Size(198, 31),
                TabIndex = 39,
                Text = "Ver mais",
                Type = MaterialButton.MaterialButtonType.Contained,
                UseAccentColor = false,
                UseVisualStyleBackColor = true
            };
        }

        public AppointmentRequestCard Build()
        {
            var card = new AppointmentRequestCard(_navegationService)
            {
                Size = new Size(218, 206),
                Padding = new Padding(14),
                Margin = new Padding(14),
                Appointment = _appointment,
                Name = $"cardAppointment-{_appointment.Id}"
            };

            var cardCustomerName = CreateCustomerNameTitle();
            var cardConfirmAppointmentCheckBox = CreateConfirmAppointmentCheckBox();
            var (cardDate, cardTime) = CreateDateAndTimeLabels();
            var cardWeekDay = CreateWeekDay();
            var cardServiceName = CreateServiceName();
            var showMoreInfoButton = CreateShowMoreInfoButton();

            card.Controls.Add(cardCustomerName);
            card.Controls.Add(cardConfirmAppointmentCheckBox);
            card.Controls.Add(cardDate);
            card.Controls.Add(cardTime);
            card.Controls.Add(cardWeekDay);
            card.Controls.Add(cardServiceName);
            card.Controls.Add(showMoreInfoButton);

            card.AddEventClickShowMoreInfoButton();
            card.AddEventCheckedChangedIsAppointmentSelectedCheckBox();

            return card;
        }
    }
    #endregion
}