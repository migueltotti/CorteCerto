using CorteCerto.App.Helpers;
using ReaLTaiizor.Controls;

namespace CorteCerto.App.Components;

internal class BarberAvailabilityCard : MaterialCard
{
    public string DayOfWeek { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? EndTime { get; set; }

    private BarberAvailabilityCard() { }

    public void SetAvailability(DateTime startTime, DateTime endTime)
    {
        StartTime = startTime;
        EndTime = endTime;

        foreach (var control in Controls)
        {
            if(control is Label lblStart && lblStart.Name == "lblStartTime")
            {
                lblStart.Text = StartTime.Value.ToLocalTime().ToShortTimeString();
            }

            if (control is Label lblEnd && lblEnd.Name == "lblEndTime")
            {
                lblEnd.Text = EndTime.Value.ToLocalTime().ToShortTimeString();
            }
        }
    }

    public class Builder()
    {
        private string DayOfWeek;
        private DateTime? StartTime;
        private DateTime? EndTime;

        public static Builder Create(DayOfWeek dayOfWeek)
        {
            var builder = new Builder
            {
                DayOfWeek = dayOfWeek.ToPortuguese()
            };

            return builder;
        }
        public Builder WithStartTime(DateTime? startTime)
        {
            StartTime = startTime;
            return this;
        }
        public Builder WithEndTime(DateTime? endTime)
        {
            EndTime = endTime;
            return this;
        }

        private Label CreateDayOfWeekTitleLabel()
        {
            return new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.Black,
                Location = new Point(14, 26),
                Name = "label17",
                Size = new Size(115, 31),
                TabIndex = 28,
                Text = DayOfWeek
            };
        }

        private (Label startTime, Label time) CreateStartTimeLabels()
        {
            var lblTitle = new Label
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(18, 67),
                Size = new Size(121, 23),
                TabIndex = 26,
                Text = "Horário Inicio:"
            };

            var lblStartTime = new Label()
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Location = new Point(18, 90),
                Name = "lblStartTime",
                Size = new Size(121, 23),
                TabIndex = 29,
                Text = StartTime?.ToLocalTime().ToString("HH:mm") ?? "--:--"
            };

            return (lblTitle, lblStartTime);
        }

        private (Label title, Label endTime) CreateEndTimeLabels()
        {
            var lblTitle = new Label
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(18, 124),
                Size = new Size(186, 23),
                TabIndex = 30,
                Text = "Horário Encerramento:"
            };

            var lblEndTime = new Label()
            {
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Black,
                Location = new Point(18, 147),
                Name = "lblEndTime",
                Size = new Size(121, 23),
                TabIndex = 31,
                Text = EndTime?.ToLocalTime().ToString("HH:mm") ?? "--:--"
            };

            return (lblTitle, lblEndTime);
        }

        private MaterialButton CreateEditButton()
        {
            var btnEditDayAvailability = new MaterialButton
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                AutoSize = false,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = SystemColors.Control,
                Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default,
                Depth = 0,
                HighEmphasis = true,
                Icon = null,
                IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase,
                Location = new Point(18, 190),
                Margin = new Padding(4, 6, 4, 6),
                MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER,
                Name = DayOfWeek,
                NoAccentTextColor = Color.Empty,
                Size = new Size(214, 36),
                TabIndex = 27,
                Text = "Editar",
                Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined,
                UseAccentColor = false,
                UseVisualStyleBackColor = false
            };

            return btnEditDayAvailability;
        }

        public BarberAvailabilityCard Build()
        {
            var card = new BarberAvailabilityCard
            {
                Size = new Size(250, 246),
                Padding = new Padding(14),
                Margin = new Padding(14),
                DayOfWeek = DayOfWeek,
                StartTime = StartTime,
                EndTime = EndTime,
                Name = $"card{DayOfWeek}Availability"
            };

            var cardTitle = CreateDayOfWeekTitleLabel();
            var (startTimeLabel, startTimeTitleLabel) = CreateStartTimeLabels();
            var (endTimeLabel, endTimeTitleLabel) = CreateEndTimeLabels();
            var editButton = CreateEditButton();

            card.Controls.Add(cardTitle);
            card.Controls.Add(startTimeTitleLabel);
            card.Controls.Add(startTimeLabel);
            card.Controls.Add(endTimeTitleLabel);
            card.Controls.Add(endTimeLabel);
            card.Controls.Add(editButton);

            return card;
        }
    }
}
