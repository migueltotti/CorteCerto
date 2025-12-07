using CorteCerto.App.Helpers;
using CorteCerto.App.Interfaces;
using CorteCerto.App.Pages;
using CorteCerto.Application.DTO;
using ReaLTaiizor.Controls;

namespace CorteCerto.App.Components;

internal class ServiceCard : MaterialCard
{
    #region Variables
    public ServiceDto Service;
    private readonly ISessionService _sessionService;
    private readonly ICustomMediator _mediator;
    #endregion

    #region Methods
    private ServiceCard(ISessionService sessionService, ICustomMediator mediator)
    {
        _sessionService = sessionService;
        _mediator = mediator;
    }

    private void AddEventClickToButton()
    {
        foreach (var control in Controls)
        {
            if (control is MaterialButton btnSchedule && btnSchedule.Name == $"btnScheduleService-{Service.Id::5}")
            {
                btnSchedule.Click += BtnScheduleService_Click;
                break;
            }

            if (control is MaterialButton btnEdit && btnEdit.Name == $"btnEditService-{Service.Id::5}")
            {
                btnEdit.Click += BtnEditService_Click;
                break;
            }
        }
    }
    #endregion

    #region Events
    private void BtnScheduleService_Click(object? sender, EventArgs e)
    {
        var scheduleForm = new RegisterAppointmentForm(_mediator, _sessionService);

        scheduleForm.ShowDialog();

        scheduleForm.Dispose();
    }

    private void BtnEditService_Click(object? sender, EventArgs e)
    {
        var editForm = new RegisterServiceForm(_mediator, _sessionService);

        editForm.ShowDialog();

        editForm.Dispose();
    }
    #endregion

    #region Builder Class
    public class Builder()
    {
        private ServiceDto _service;
        private bool _editButtonIncluded = false;
        private ISessionService _sessionService;
        private ICustomMediator _mediator;

        public static Builder Create(ISessionService sessionService, ICustomMediator mediator)
        {
            var builder = new Builder()
            {
                _sessionService = sessionService,
                _mediator = mediator
            };

            return builder;
        }

        public Builder WithService(ServiceDto service)
        {
            _service = service;
            return this;
        }

        public Builder WithEditButtonInsteadOfSchedule()
        {
            _editButtonIncluded = true;
            return this;
        }

        private Label CreateTitleLabel()
        {
            return new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(13, 13),
                Name = $"lblName-{_service.Id::5}",
                Size = new Size(103, 31),
                TabIndex = 29,
                Text = _service.Name
            };
        }

        private Label CreateDescriptionLabel()
        {
            return new Label
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(17, 44),
                Name = $"lblDescription-{_service.Id::5}",
                Size = new Size(429, 46),
                TabIndex = 29,
                Text = _service.Description
            };
        }

        private (Label price, Label priceValue) CreatePriceLabels()
        {
            var lblPrice = new Label()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(457, 14),
                Name = $"lblPrice-{_service.Id::5}",
                Size = new Size(57, 23),
                TabIndex = 42,
                Text = "Preço:"
            };

            var lblPriceValue = new Label()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Location = new Point(457, 38),
                Name = "label27",
                Size = new Size(74, 23),
                TabIndex = 42,
                Text = $"R$ {_service.Price:F2}"
            };

            return (lblPrice, lblPriceValue);
        }

        private (Label duration, Label durationValue) CreateDurationLabels()
        {
            var lblDuration = new Label()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(457, 61),
                Name = $"lblDuration-{_service.Id::5}",
                Size = new Size(78, 23),
                TabIndex = 43,
                Text = "Duração:"
            };

            var lblDurationValue = new Label()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Location = new Point(457, 84),
                Name = $"lblDurationValue-{_service.Id::5}",
                Size = new Size(62, 23),
                TabIndex = 44,
                Text = $"{_service.Duration.TotalMinutes} min"
            };

            return (lblDuration, lblDurationValue);
        }

        private MaterialButton CreateScheduleServiceButton()
        {
            var btnScheduleService = new MaterialButton
            {
                Anchor = AnchorStyles.Right,
                AutoSize = false,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default,
                Depth = 0,
                ForeColor = Color.Black,
                HighEmphasis = true,
                Icon = null,
                IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default,
                Location = new Point(589, 38),
                Margin = new Padding(4, 6, 4, 6),
                MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER,
                Name = $"btnScheduleService-{_service.Id::5}",
                NoAccentTextColor = Color.Empty,
                Size = new Size(91, 40),
                TabIndex = 41,
                Text = "Agendar",
                Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined,
                UseAccentColor = true,
                UseVisualStyleBackColor = true
            };

            return btnScheduleService;
        }

        private MaterialButton CreateEditServiceButton()
        {
            var btnEditService = new MaterialButton
            {
                Anchor = AnchorStyles.Right,
                AutoSize = false,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default,
                Depth = 0,
                ForeColor = Color.Black,
                HighEmphasis = true,
                Icon = null,
                IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default,
                Location = new Point(589, 38),
                Margin = new Padding(4, 6, 4, 6),
                MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER,
                Name = $"btnEditService-{_service.Id::5}",
                NoAccentTextColor = Color.Empty,
                Size = new Size(91, 40),
                TabIndex = 41,
                Text = "Editart",
                Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined,
                UseVisualStyleBackColor = true
            };

            return btnEditService;
        }

        public ServiceCard Build()
        {
            var card = new ServiceCard(_sessionService, _mediator)
            {
                Size = new Size(698, 121),
                Padding = new Padding(14),
                Margin = new Padding(14),
                Service = _service,
                Name = $"cardService-{_service.Id::8}"
            };

            var cardTitle = CreateTitleLabel();
            var cardDescription = CreateDescriptionLabel();
            var (priceLabel, priceValueLabel) = CreatePriceLabels();
            var (durationLabel, durationValueLabel) = CreateDurationLabels();

            var button = _editButtonIncluded ? CreateEditServiceButton() : CreateScheduleServiceButton();

            card.Controls.Add(cardTitle);
            card.Controls.Add(cardDescription);
            card.Controls.Add(priceLabel);
            card.Controls.Add(priceValueLabel);
            card.Controls.Add(durationLabel);
            card.Controls.Add(durationValueLabel);
            card.Controls.Add(button);

            card.AddEventClickToButton();

            return card;
        }
    }
    #endregion
}
