namespace CorteCerto.App.Pages
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sideBar = new ReaLTaiizor.Controls.MaterialCard();
            button1 = new ReaLTaiizor.Controls.Button();
            label6 = new Label();
            btnLogout = new ReaLTaiizor.Controls.MaterialButton();
            btnUserAction = new ReaLTaiizor.Controls.MaterialButton();
            lblUserEmail = new Label();
            lblUserName = new Label();
            parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            separator1 = new ReaLTaiizor.Controls.Separator();
            btnConfigurations = new ReaLTaiizor.Controls.Button();
            btnReports = new ReaLTaiizor.Controls.Button();
            label3 = new Label();
            btnBarbers = new ReaLTaiizor.Controls.Button();
            btnServices = new ReaLTaiizor.Controls.Button();
            label2 = new Label();
            btnAppoitments = new ReaLTaiizor.Controls.Button();
            btnDashboard = new ReaLTaiizor.Controls.Button();
            label1 = new Label();
            tabControlMain = new TabControl();
            tabPageDashboard = new TabPage();
            dashboardCard = new ReaLTaiizor.Controls.MaterialCard();
            btnDashboardNewAppointment = new ReaLTaiizor.Controls.MaterialButton();
            btnDashboardNewService = new ReaLTaiizor.Controls.MaterialButton();
            label11 = new Label();
            label4 = new Label();
            tabPageAppointments = new TabPage();
            calendarCard = new ReaLTaiizor.Controls.MaterialCard();
            listView1 = new ListView();
            btnYearCalendar = new ReaLTaiizor.Controls.ParrotButton();
            btnMonthCalendar = new ReaLTaiizor.Controls.ParrotButton();
            btnWeekCalendar = new ReaLTaiizor.Controls.ParrotButton();
            label5 = new Label();
            label14 = new Label();
            appointmentCard = new ReaLTaiizor.Controls.MaterialCard();
            btnNewAppointment = new ReaLTaiizor.Controls.MaterialButton();
            label12 = new Label();
            label13 = new Label();
            tabPageServices = new TabPage();
            label7 = new Label();
            tabPageBarbers = new TabPage();
            label8 = new Label();
            tabPageReports = new TabPage();
            label9 = new Label();
            tabPageConfigurations = new TabPage();
            label10 = new Label();
            tabPageAvailability = new TabPage();
            materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton4 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton5 = new ReaLTaiizor.Controls.MaterialButton();
            materialButton6 = new ReaLTaiizor.Controls.MaterialButton();
            sideBar.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            dashboardCard.SuspendLayout();
            tabPageAppointments.SuspendLayout();
            calendarCard.SuspendLayout();
            appointmentCard.SuspendLayout();
            tabPageServices.SuspendLayout();
            tabPageBarbers.SuspendLayout();
            tabPageReports.SuspendLayout();
            tabPageConfigurations.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideBar.BackColor = Color.FromArgb(255, 255, 255);
            sideBar.Controls.Add(button1);
            sideBar.Controls.Add(label6);
            sideBar.Controls.Add(btnLogout);
            sideBar.Controls.Add(btnUserAction);
            sideBar.Controls.Add(lblUserEmail);
            sideBar.Controls.Add(lblUserName);
            sideBar.Controls.Add(parrotButton2);
            sideBar.Controls.Add(separator1);
            sideBar.Controls.Add(btnConfigurations);
            sideBar.Controls.Add(btnReports);
            sideBar.Controls.Add(label3);
            sideBar.Controls.Add(btnBarbers);
            sideBar.Controls.Add(btnServices);
            sideBar.Controls.Add(label2);
            sideBar.Controls.Add(btnAppoitments);
            sideBar.Controls.Add(btnDashboard);
            sideBar.Controls.Add(label1);
            sideBar.Depth = 0;
            sideBar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            sideBar.Location = new Point(7, 69);
            sideBar.Margin = new Padding(14);
            sideBar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            sideBar.Name = "sideBar";
            sideBar.Padding = new Padding(14);
            sideBar.Size = new Size(314, 700);
            sideBar.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.Transparent;
            button1.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            button1.EnteredColor = Color.FromArgb(184, 184, 184);
            button1.Font = new Font("Segoe UI", 11F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.Transparent;
            button1.Location = new Point(26, 282);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(11, 153, 255);
            button1.PressedColor = Color.FromArgb(73, 167, 235);
            button1.Size = new Size(221, 35);
            button1.TabIndex = 25;
            button1.Tag = "7";
            button1.Text = "Disponibilidade";
            button1.TextAlignment = StringAlignment.Near;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.RoyalBlue;
            label6.Location = new Point(13, 14);
            label6.Name = "label6";
            label6.Size = new Size(169, 38);
            label6.TabIndex = 24;
            label6.Text = "Corte Certo";
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.AutoSize = false;
            btnLogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogout.BackColor = SystemColors.Control;
            btnLogout.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLogout.Location = new Point(155, 634);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(133, 36);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Sair";
            btnLogout.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogout.UseAccentColor = true;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUserAction
            // 
            btnUserAction.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUserAction.AutoSize = false;
            btnUserAction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUserAction.BackColor = SystemColors.Control;
            btnUserAction.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUserAction.Depth = 0;
            btnUserAction.HighEmphasis = true;
            btnUserAction.Icon = null;
            btnUserAction.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnUserAction.Location = new Point(13, 634);
            btnUserAction.Margin = new Padding(4, 6, 4, 6);
            btnUserAction.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnUserAction.Name = "btnUserAction";
            btnUserAction.NoAccentTextColor = Color.Empty;
            btnUserAction.Size = new Size(133, 36);
            btnUserAction.TabIndex = 13;
            btnUserAction.Text = "Perfil";
            btnUserAction.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnUserAction.UseAccentColor = false;
            btnUserAction.UseVisualStyleBackColor = false;
            btnUserAction.Click += btnUserAction_Click;
            // 
            // lblUserEmail
            // 
            lblUserEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserEmail.Font = new Font("Segoe UI", 10F);
            lblUserEmail.ForeColor = Color.Gray;
            lblUserEmail.Location = new Point(87, 596);
            lblUserEmail.Name = "lblUserEmail";
            lblUserEmail.Size = new Size(210, 23);
            lblUserEmail.TabIndex = 22;
            lblUserEmail.Text = "nome@gmail.com";
            // 
            // lblUserName
            // 
            lblUserName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUserName.ForeColor = Color.Black;
            lblUserName.Location = new Point(87, 562);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(210, 28);
            lblUserName.TabIndex = 21;
            lblUserName.Text = "Nome Usuário";
            // 
            // parrotButton2
            // 
            parrotButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            parrotButton2.BackgroundColor = Color.Transparent;
            parrotButton2.ButtonImage = Properties.Resources.user;
            parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton2.ButtonText = "";
            parrotButton2.ClickBackColor = Color.FromArgb(73, 167, 235);
            parrotButton2.ClickTextColor = Color.Black;
            parrotButton2.CornerRadius = 10;
            parrotButton2.Font = new Font("Microsoft Sans Serif", 14F);
            parrotButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotButton2.HoverBackgroundColor = Color.FromArgb(192, 244, 255);
            parrotButton2.HoverTextColor = Color.Black;
            parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton2.Location = new Point(26, 562);
            parrotButton2.Name = "parrotButton2";
            parrotButton2.Size = new Size(45, 42);
            parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton2.TabIndex = 13;
            parrotButton2.TextColor = Color.Black;
            parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton2.Vertical_Alignment = StringAlignment.Center;
            // 
            // separator1
            // 
            separator1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            separator1.LineColor = Color.Gray;
            separator1.Location = new Point(13, 544);
            separator1.Name = "separator1";
            separator1.Size = new Size(275, 8);
            separator1.TabIndex = 20;
            separator1.Text = "separator1";
            // 
            // btnConfigurations
            // 
            btnConfigurations.BackColor = Color.Transparent;
            btnConfigurations.BorderColor = Color.Transparent;
            btnConfigurations.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnConfigurations.EnteredColor = Color.FromArgb(184, 184, 184);
            btnConfigurations.Font = new Font("Segoe UI", 11F);
            btnConfigurations.Image = null;
            btnConfigurations.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfigurations.InactiveColor = Color.Transparent;
            btnConfigurations.Location = new Point(26, 395);
            btnConfigurations.Name = "btnConfigurations";
            btnConfigurations.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnConfigurations.PressedColor = Color.FromArgb(73, 167, 235);
            btnConfigurations.Size = new Size(221, 35);
            btnConfigurations.TabIndex = 19;
            btnConfigurations.Tag = "6";
            btnConfigurations.Text = "Configurações";
            btnConfigurations.TextAlignment = StringAlignment.Near;
            btnConfigurations.Click += btnConfigurations_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Transparent;
            btnReports.BorderColor = Color.Transparent;
            btnReports.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnReports.EnteredColor = Color.FromArgb(184, 184, 184);
            btnReports.Font = new Font("Segoe UI", 11F);
            btnReports.Image = null;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.InactiveColor = Color.Transparent;
            btnReports.Location = new Point(26, 354);
            btnReports.Name = "btnReports";
            btnReports.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnReports.PressedColor = Color.FromArgb(73, 167, 235);
            btnReports.Size = new Size(221, 35);
            btnReports.TabIndex = 18;
            btnReports.Tag = "5";
            btnReports.Text = "Relatórios";
            btnReports.TextAlignment = StringAlignment.Near;
            btnReports.Click += btnReports_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(13, 328);
            label3.Name = "label3";
            label3.Size = new Size(119, 23);
            label3.TabIndex = 17;
            label3.Text = "Administração";
            // 
            // btnBarbers
            // 
            btnBarbers.BackColor = Color.Transparent;
            btnBarbers.BorderColor = Color.Transparent;
            btnBarbers.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnBarbers.EnteredColor = Color.FromArgb(184, 184, 184);
            btnBarbers.Font = new Font("Segoe UI", 11F);
            btnBarbers.Image = null;
            btnBarbers.ImageAlign = ContentAlignment.MiddleLeft;
            btnBarbers.InactiveColor = Color.Transparent;
            btnBarbers.Location = new Point(26, 237);
            btnBarbers.Name = "btnBarbers";
            btnBarbers.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnBarbers.PressedColor = Color.FromArgb(73, 167, 235);
            btnBarbers.Size = new Size(221, 35);
            btnBarbers.TabIndex = 16;
            btnBarbers.Tag = "3";
            btnBarbers.Text = "Barbeiros";
            btnBarbers.TextAlignment = StringAlignment.Near;
            btnBarbers.Click += btnBarbers_Click;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.Transparent;
            btnServices.BorderColor = Color.Transparent;
            btnServices.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnServices.EnteredColor = Color.FromArgb(184, 184, 184);
            btnServices.Font = new Font("Segoe UI", 11F);
            btnServices.Image = null;
            btnServices.ImageAlign = ContentAlignment.MiddleLeft;
            btnServices.InactiveColor = Color.Transparent;
            btnServices.Location = new Point(26, 196);
            btnServices.Name = "btnServices";
            btnServices.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnServices.PressedColor = Color.FromArgb(73, 167, 235);
            btnServices.Size = new Size(221, 35);
            btnServices.TabIndex = 15;
            btnServices.Tag = "2";
            btnServices.Text = "Serviços";
            btnServices.TextAlignment = StringAlignment.Near;
            btnServices.Click += btnServices_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(13, 170);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 14;
            label2.Text = "Operações";
            // 
            // btnAppoitments
            // 
            btnAppoitments.BackColor = Color.Transparent;
            btnAppoitments.BorderColor = Color.Transparent;
            btnAppoitments.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnAppoitments.EnteredColor = Color.FromArgb(184, 184, 184);
            btnAppoitments.Font = new Font("Segoe UI", 11F);
            btnAppoitments.Image = null;
            btnAppoitments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppoitments.InactiveColor = Color.Transparent;
            btnAppoitments.Location = new Point(26, 129);
            btnAppoitments.Name = "btnAppoitments";
            btnAppoitments.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnAppoitments.PressedColor = Color.FromArgb(73, 167, 235);
            btnAppoitments.Size = new Size(221, 35);
            btnAppoitments.TabIndex = 13;
            btnAppoitments.Tag = "1";
            btnAppoitments.Text = "Agendamentos";
            btnAppoitments.TextAlignment = StringAlignment.Near;
            btnAppoitments.Click += btnAppoitments_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.BorderColor = Color.Transparent;
            btnDashboard.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnDashboard.EnteredColor = Color.FromArgb(184, 184, 184);
            btnDashboard.Font = new Font("Segoe UI", 11F);
            btnDashboard.Image = null;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.InactiveColor = Color.Transparent;
            btnDashboard.Location = new Point(26, 88);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnDashboard.PressedColor = Color.FromArgb(73, 167, 235);
            btnDashboard.Size = new Size(221, 35);
            btnDashboard.TabIndex = 12;
            btnDashboard.Tag = "0";
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlignment = StringAlignment.Near;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(13, 62);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 0;
            label1.Text = "Visão geral";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageDashboard);
            tabControlMain.Controls.Add(tabPageAppointments);
            tabControlMain.Controls.Add(tabPageServices);
            tabControlMain.Controls.Add(tabPageBarbers);
            tabControlMain.Controls.Add(tabPageReports);
            tabControlMain.Controls.Add(tabPageConfigurations);
            tabControlMain.Controls.Add(tabPageAvailability);
            tabControlMain.Location = new Point(329, 67);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1004, 701);
            tabControlMain.TabIndex = 12;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(dashboardCard);
            tabPageDashboard.Location = new Point(4, 29);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(996, 668);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Dashboard";
            tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // dashboardCard
            // 
            dashboardCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dashboardCard.BackColor = Color.FromArgb(255, 255, 255);
            dashboardCard.Controls.Add(btnDashboardNewAppointment);
            dashboardCard.Controls.Add(btnDashboardNewService);
            dashboardCard.Controls.Add(label11);
            dashboardCard.Controls.Add(label4);
            dashboardCard.Depth = 0;
            dashboardCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dashboardCard.Location = new Point(17, 0);
            dashboardCard.Margin = new Padding(14);
            dashboardCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            dashboardCard.Name = "dashboardCard";
            dashboardCard.Padding = new Padding(14);
            dashboardCard.Size = new Size(965, 106);
            dashboardCard.TabIndex = 25;
            // 
            // btnDashboardNewAppointment
            // 
            btnDashboardNewAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDashboardNewAppointment.AutoSize = false;
            btnDashboardNewAppointment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboardNewAppointment.BackColor = SystemColors.Control;
            btnDashboardNewAppointment.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDashboardNewAppointment.Depth = 0;
            btnDashboardNewAppointment.HighEmphasis = true;
            btnDashboardNewAppointment.Icon = Properties.Resources.calendar_plus;
            btnDashboardNewAppointment.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDashboardNewAppointment.Location = new Point(579, 27);
            btnDashboardNewAppointment.Margin = new Padding(4, 6, 4, 6);
            btnDashboardNewAppointment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDashboardNewAppointment.Name = "btnDashboardNewAppointment";
            btnDashboardNewAppointment.NoAccentTextColor = Color.Empty;
            btnDashboardNewAppointment.Size = new Size(193, 49);
            btnDashboardNewAppointment.TabIndex = 26;
            btnDashboardNewAppointment.Text = "Novo Agendamento";
            btnDashboardNewAppointment.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDashboardNewAppointment.UseAccentColor = false;
            btnDashboardNewAppointment.UseVisualStyleBackColor = false;
            btnDashboardNewAppointment.Click += btnDashboardNewAppointment_Click;
            // 
            // btnDashboardNewService
            // 
            btnDashboardNewService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDashboardNewService.AutoSize = false;
            btnDashboardNewService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboardNewService.BackColor = SystemColors.Control;
            btnDashboardNewService.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDashboardNewService.Depth = 0;
            btnDashboardNewService.HighEmphasis = true;
            btnDashboardNewService.Icon = Properties.Resources.barber_pole;
            btnDashboardNewService.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDashboardNewService.Location = new Point(780, 27);
            btnDashboardNewService.Margin = new Padding(4, 6, 4, 6);
            btnDashboardNewService.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDashboardNewService.Name = "btnDashboardNewService";
            btnDashboardNewService.NoAccentTextColor = Color.Empty;
            btnDashboardNewService.Size = new Size(153, 49);
            btnDashboardNewService.TabIndex = 25;
            btnDashboardNewService.Text = "Novo Serviço";
            btnDashboardNewService.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnDashboardNewService.UseAccentColor = false;
            btnDashboardNewService.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(17, 61);
            label11.Name = "label11";
            label11.Size = new Size(408, 23);
            label11.TabIndex = 25;
            label11.Text = "Resumo dos agendamos e desenpenho do barbeiro.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(17, 14);
            label4.Name = "label4";
            label4.Size = new Size(159, 38);
            label4.TabIndex = 25;
            label4.Text = "Dashboard";
            // 
            // tabPageAppointments
            // 
            tabPageAppointments.Controls.Add(calendarCard);
            tabPageAppointments.Controls.Add(appointmentCard);
            tabPageAppointments.Location = new Point(4, 29);
            tabPageAppointments.Name = "tabPageAppointments";
            tabPageAppointments.Padding = new Padding(3);
            tabPageAppointments.Size = new Size(996, 668);
            tabPageAppointments.TabIndex = 1;
            tabPageAppointments.Text = "Appointments";
            tabPageAppointments.UseVisualStyleBackColor = true;
            // 
            // calendarCard
            // 
            calendarCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            calendarCard.BackColor = Color.FromArgb(255, 255, 255);
            calendarCard.Controls.Add(listView1);
            calendarCard.Controls.Add(btnYearCalendar);
            calendarCard.Controls.Add(btnMonthCalendar);
            calendarCard.Controls.Add(btnWeekCalendar);
            calendarCard.Controls.Add(label5);
            calendarCard.Controls.Add(label14);
            calendarCard.Depth = 0;
            calendarCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            calendarCard.Location = new Point(14, 113);
            calendarCard.Margin = new Padding(14);
            calendarCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            calendarCard.Name = "calendarCard";
            calendarCard.Padding = new Padding(14);
            calendarCard.Size = new Size(965, 538);
            calendarCard.TabIndex = 28;
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.Location = new Point(17, 72);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(930, 449);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnYearCalendar
            // 
            btnYearCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnYearCalendar.BackgroundColor = Color.Gray;
            btnYearCalendar.ButtonImage = null;
            btnYearCalendar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnYearCalendar.ButtonText = "Ano";
            btnYearCalendar.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnYearCalendar.ClickTextColor = Color.DodgerBlue;
            btnYearCalendar.CornerRadius = 20;
            btnYearCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnYearCalendar.Horizontal_Alignment = StringAlignment.Center;
            btnYearCalendar.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnYearCalendar.HoverTextColor = Color.DodgerBlue;
            btnYearCalendar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnYearCalendar.Location = new Point(864, 17);
            btnYearCalendar.Name = "btnYearCalendar";
            btnYearCalendar.Size = new Size(84, 40);
            btnYearCalendar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnYearCalendar.TabIndex = 31;
            btnYearCalendar.TextColor = Color.White;
            btnYearCalendar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnYearCalendar.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnMonthCalendar
            // 
            btnMonthCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMonthCalendar.BackgroundColor = Color.Gray;
            btnMonthCalendar.ButtonImage = null;
            btnMonthCalendar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnMonthCalendar.ButtonText = "Mês";
            btnMonthCalendar.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnMonthCalendar.ClickTextColor = Color.DodgerBlue;
            btnMonthCalendar.CornerRadius = 20;
            btnMonthCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMonthCalendar.Horizontal_Alignment = StringAlignment.Center;
            btnMonthCalendar.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnMonthCalendar.HoverTextColor = Color.DodgerBlue;
            btnMonthCalendar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnMonthCalendar.Location = new Point(774, 17);
            btnMonthCalendar.Name = "btnMonthCalendar";
            btnMonthCalendar.Size = new Size(84, 40);
            btnMonthCalendar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnMonthCalendar.TabIndex = 30;
            btnMonthCalendar.TextColor = Color.White;
            btnMonthCalendar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnMonthCalendar.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnWeekCalendar
            // 
            btnWeekCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWeekCalendar.BackgroundColor = Color.Gray;
            btnWeekCalendar.ButtonImage = null;
            btnWeekCalendar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnWeekCalendar.ButtonText = "Semana";
            btnWeekCalendar.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnWeekCalendar.ClickTextColor = Color.DodgerBlue;
            btnWeekCalendar.CornerRadius = 20;
            btnWeekCalendar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWeekCalendar.Horizontal_Alignment = StringAlignment.Center;
            btnWeekCalendar.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnWeekCalendar.HoverTextColor = Color.DodgerBlue;
            btnWeekCalendar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnWeekCalendar.Location = new Point(684, 17);
            btnWeekCalendar.Name = "btnWeekCalendar";
            btnWeekCalendar.Size = new Size(84, 40);
            btnWeekCalendar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnWeekCalendar.TabIndex = 29;
            btnWeekCalendar.TextColor = Color.White;
            btnWeekCalendar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnWeekCalendar.Vertical_Alignment = StringAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(17, 46);
            label5.Name = "label5";
            label5.Size = new Size(434, 23);
            label5.TabIndex = 25;
            label5.Text = "Distribuição dos horários de agendamento por período.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(17, 14);
            label14.Name = "label14";
            label14.Size = new Size(146, 32);
            label14.TabIndex = 25;
            label14.Text = "Sua agenda";
            // 
            // appointmentCard
            // 
            appointmentCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            appointmentCard.BackColor = Color.FromArgb(255, 255, 255);
            appointmentCard.Controls.Add(btnNewAppointment);
            appointmentCard.Controls.Add(label12);
            appointmentCard.Controls.Add(label13);
            appointmentCard.Depth = 0;
            appointmentCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            appointmentCard.Location = new Point(14, 0);
            appointmentCard.Margin = new Padding(14);
            appointmentCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            appointmentCard.Name = "appointmentCard";
            appointmentCard.Padding = new Padding(14);
            appointmentCard.Size = new Size(965, 106);
            appointmentCard.TabIndex = 27;
            // 
            // btnNewAppointment
            // 
            btnNewAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewAppointment.AutoSize = false;
            btnNewAppointment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNewAppointment.BackColor = SystemColors.Control;
            btnNewAppointment.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNewAppointment.Depth = 0;
            btnNewAppointment.HighEmphasis = true;
            btnNewAppointment.Icon = Properties.Resources.calendar_plus;
            btnNewAppointment.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNewAppointment.Location = new Point(754, 32);
            btnNewAppointment.Margin = new Padding(4, 6, 4, 6);
            btnNewAppointment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNewAppointment.Name = "btnNewAppointment";
            btnNewAppointment.NoAccentTextColor = Color.Empty;
            btnNewAppointment.Size = new Size(193, 49);
            btnNewAppointment.TabIndex = 27;
            btnNewAppointment.Text = "Novo Agendamento";
            btnNewAppointment.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNewAppointment.UseAccentColor = false;
            btnNewAppointment.UseVisualStyleBackColor = false;
            btnNewAppointment.Click += btnNewAppointment_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(17, 61);
            label12.Name = "label12";
            label12.Size = new Size(225, 23);
            label12.TabIndex = 25;
            label12.Text = "Analise seus agendamentos.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(17, 14);
            label13.Name = "label13";
            label13.Size = new Size(216, 38);
            label13.TabIndex = 25;
            label13.Text = "Agendamentos";
            // 
            // tabPageServices
            // 
            tabPageServices.Controls.Add(label7);
            tabPageServices.Location = new Point(4, 29);
            tabPageServices.Name = "tabPageServices";
            tabPageServices.Padding = new Padding(3);
            tabPageServices.Size = new Size(996, 668);
            tabPageServices.TabIndex = 2;
            tabPageServices.Text = "Services";
            tabPageServices.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(72, 47);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 27;
            label7.Text = "Services";
            // 
            // tabPageBarbers
            // 
            tabPageBarbers.Controls.Add(label8);
            tabPageBarbers.Location = new Point(4, 29);
            tabPageBarbers.Name = "tabPageBarbers";
            tabPageBarbers.Padding = new Padding(3);
            tabPageBarbers.Size = new Size(996, 668);
            tabPageBarbers.TabIndex = 3;
            tabPageBarbers.Text = "Barbers";
            tabPageBarbers.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(96, 73);
            label8.Name = "label8";
            label8.Size = new Size(67, 23);
            label8.TabIndex = 28;
            label8.Text = "Barbers";
            // 
            // tabPageReports
            // 
            tabPageReports.Controls.Add(label9);
            tabPageReports.Location = new Point(4, 29);
            tabPageReports.Name = "tabPageReports";
            tabPageReports.Padding = new Padding(3);
            tabPageReports.Size = new Size(996, 668);
            tabPageReports.TabIndex = 4;
            tabPageReports.Text = "Reports";
            tabPageReports.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(88, 61);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 29;
            label9.Text = "Reports";
            // 
            // tabPageConfigurations
            // 
            tabPageConfigurations.Controls.Add(label10);
            tabPageConfigurations.Location = new Point(4, 29);
            tabPageConfigurations.Name = "tabPageConfigurations";
            tabPageConfigurations.Padding = new Padding(3);
            tabPageConfigurations.Size = new Size(996, 668);
            tabPageConfigurations.TabIndex = 5;
            tabPageConfigurations.Text = "Configurations";
            tabPageConfigurations.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(57, 35);
            label10.Name = "label10";
            label10.Size = new Size(122, 23);
            label10.TabIndex = 30;
            label10.Text = "Configurations";
            // 
            // tabPageAvailability
            // 
            tabPageAvailability.Location = new Point(4, 29);
            tabPageAvailability.Name = "tabPageAvailability";
            tabPageAvailability.Padding = new Padding(3);
            tabPageAvailability.Size = new Size(996, 668);
            tabPageAvailability.TabIndex = 6;
            tabPageAvailability.Text = "Availability";
            tabPageAvailability.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = SystemColors.Control;
            materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = Properties.Resources.calendar_plus;
            materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton3.Location = new Point(1344, 27);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(193, 55);
            materialButton3.TabIndex = 26;
            materialButton3.Text = "Novo Agendamento";
            materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton4
            // 
            materialButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.BackColor = SystemColors.Control;
            materialButton4.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = Properties.Resources.barber_pole;
            materialButton4.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton4.Location = new Point(1545, 27);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(153, 55);
            materialButton4.TabIndex = 25;
            materialButton4.Text = "Novo Serviço";
            materialButton4.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = false;
            // 
            // materialButton5
            // 
            materialButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.BackColor = SystemColors.Control;
            materialButton5.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = Properties.Resources.calendar_plus;
            materialButton5.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton5.Location = new Point(2109, 27);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(193, 493);
            materialButton5.TabIndex = 26;
            materialButton5.Text = "Novo Agendamento";
            materialButton5.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = false;
            // 
            // materialButton6
            // 
            materialButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton6.AutoSize = false;
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.BackColor = SystemColors.Control;
            materialButton6.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = Properties.Resources.barber_pole;
            materialButton6.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            materialButton6.Location = new Point(2310, 27);
            materialButton6.Margin = new Padding(4, 6, 4, 6);
            materialButton6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(153, 493);
            materialButton6.TabIndex = 25;
            materialButton6.Text = "Novo Serviço";
            materialButton6.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 774);
            Controls.Add(tabControlMain);
            Controls.Add(sideBar);
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            dashboardCard.ResumeLayout(false);
            dashboardCard.PerformLayout();
            tabPageAppointments.ResumeLayout(false);
            calendarCard.ResumeLayout(false);
            calendarCard.PerformLayout();
            appointmentCard.ResumeLayout(false);
            appointmentCard.PerformLayout();
            tabPageServices.ResumeLayout(false);
            tabPageServices.PerformLayout();
            tabPageBarbers.ResumeLayout(false);
            tabPageBarbers.PerformLayout();
            tabPageReports.ResumeLayout(false);
            tabPageReports.PerformLayout();
            tabPageConfigurations.ResumeLayout(false);
            tabPageConfigurations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialCard sideBar;
        private Label label1;
        private ReaLTaiizor.Controls.Button btnServices;
        private ReaLTaiizor.Controls.Button btnAppoitments;
        private ReaLTaiizor.Controls.Button btnBarbers;
        private Label label2;
        private ReaLTaiizor.Controls.Button btnConfigurations;
        private ReaLTaiizor.Controls.Button btnReports;
        private Label label3;
        private ReaLTaiizor.Controls.Separator separator1;
        private ReaLTaiizor.Controls.MaterialButton btnUserAction;
        private Label lblUserEmail;
        private Label lblUserName;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private ReaLTaiizor.Controls.MaterialButton btnLogout;
        private ReaLTaiizor.Controls.Button btnDashboard;
        private TabControl tabControlMain;
        private TabPage tabPageDashboard;
        private TabPage tabPageAppointments;
        private TabPage tabPageServices;
        private TabPage tabPageBarbers;
        private TabPage tabPageReports;
        private TabPage tabPageConfigurations;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ReaLTaiizor.Controls.MaterialCard dashboardCard;
        private ReaLTaiizor.Controls.MaterialButton btnDashboardNewService;
        private Label label11;
        private Label label4;
        private ReaLTaiizor.Controls.MaterialButton btnDashboardNewAppointment;
        private ReaLTaiizor.Controls.MaterialCard calendarCard;
        private ReaLTaiizor.Controls.MaterialButton materialButton5;
        private ReaLTaiizor.Controls.MaterialButton materialButton6;
        private Label label5;
        private Label label14;
        private ReaLTaiizor.Controls.MaterialCard appointmentCard;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
        private Label label12;
        private Label label13;
        private ReaLTaiizor.Controls.ParrotButton btnYearCalendar;
        private ReaLTaiizor.Controls.ParrotButton btnMonthCalendar;
        private ReaLTaiizor.Controls.ParrotButton btnWeekCalendar;
        private ReaLTaiizor.Controls.Button button1;
        private TabPage tabPageAvailability;
        private ListView listView1;
        private ReaLTaiizor.Controls.MaterialButton btnNewAppointment;
    }
}