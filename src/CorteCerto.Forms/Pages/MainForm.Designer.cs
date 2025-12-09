using ReaLTaiizor.Controls;

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
            sideBar = new MaterialCard();
            mtbRegisterBarberProfile = new MaterialButton();
            btnBarberAvailabilities = new ReaLTaiizor.Controls.Button();
            label6 = new Label();
            btnLogout = new MaterialButton();
            btnUserAction = new MaterialButton();
            lblUserEmail = new Label();
            lblUserName = new Label();
            parrotButton2 = new ParrotButton();
            separator1 = new Separator();
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
            tabPageDashboard = new System.Windows.Forms.TabPage();
            dashboardCard = new MaterialCard();
            btnDashboardNewAppointment = new MaterialButton();
            btnDashboardNewService = new MaterialButton();
            label11 = new Label();
            label4 = new Label();
            tabPageAppointments = new System.Windows.Forms.TabPage();
            calendarCard = new MaterialCard();
            mcbAppointmentStatus = new MaterialComboBox();
            btnConfirmAppointment = new MaterialButton();
            flpAppointmentRequest = new FlowLayoutPanel();
            materialCard5 = new MaterialCard();
            label51 = new Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            materialButton1 = new MaterialButton();
            label50 = new Label();
            label49 = new Label();
            label48 = new Label();
            label47 = new Label();
            label46 = new Label();
            label45 = new Label();
            flpAppointments = new FlowLayoutPanel();
            label5 = new Label();
            label14 = new Label();
            appointmentCard = new MaterialCard();
            btnNewAppointment = new MaterialButton();
            label12 = new Label();
            label13 = new Label();
            tabPageServices = new System.Windows.Forms.TabPage();
            materialCard3 = new MaterialCard();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            materialButton2 = new MaterialButton();
            label25 = new Label();
            label24 = new Label();
            flpServiceCardList = new FlowLayoutPanel();
            btnApplyFilters = new MaterialButton();
            label23 = new Label();
            mcbPriceOperatorFilter = new MaterialComboBox();
            mtbPriceFilter = new MaterialTextBoxEdit();
            label22 = new Label();
            mcbDurationOperatorFilter = new MaterialComboBox();
            mtbDurationFilter = new MaterialTextBoxEdit();
            label20 = new Label();
            btnSearchServices = new MaterialButton();
            mtbServiceName = new MaterialTextBoxEdit();
            materialCard2 = new MaterialCard();
            mtbNewService = new MaterialButton();
            label7 = new Label();
            label19 = new Label();
            tabPageBarbers = new System.Windows.Forms.TabPage();
            label8 = new Label();
            tabPageReports = new System.Windows.Forms.TabPage();
            label9 = new Label();
            tabPageConfigurations = new System.Windows.Forms.TabPage();
            btnSaveBarberChanges = new MaterialButton();
            mchbBarberEditMode = new MaterialCheckBox();
            mtbBarberAddress = new MaterialTextBoxEdit();
            label44 = new Label();
            mtbBarberAddressCity = new MaterialTextBoxEdit();
            label43 = new Label();
            mtbBarberAddressState = new MaterialTextBoxEdit();
            label42 = new Label();
            mtbBarberAddressCountry = new MaterialTextBoxEdit();
            label41 = new Label();
            mtbBarberAddressNumber = new MaterialTextBoxEdit();
            label40 = new Label();
            mtbBarberCep = new MaterialTextBoxEdit();
            label39 = new Label();
            label38 = new Label();
            mtbBarberPortifolioUrl = new MaterialTextBoxEdit();
            label37 = new Label();
            mrtbBarberDescription = new MaterialRichTextBox();
            label36 = new Label();
            btnSaveProfileChanges = new MaterialButton();
            mchbProfileEditMode = new MaterialCheckBox();
            mtbProfilePromotionPoints = new MaterialTextBoxEdit();
            label35 = new Label();
            mtbProfilePhoneNumber = new MaterialTextBoxEdit();
            label34 = new Label();
            mtbProfileEmail = new MaterialTextBoxEdit();
            label33 = new Label();
            materialCard4 = new MaterialCard();
            label10 = new Label();
            label30 = new Label();
            mtbProfileName = new MaterialTextBoxEdit();
            label32 = new Label();
            label31 = new Label();
            tabPageAvailability = new System.Windows.Forms.TabPage();
            cardSaturdayAvailability = new MaterialCard();
            lblEndTime = new Label();
            label21 = new Label();
            lblStartTime = new Label();
            label18 = new Label();
            btnEditDayAvailability = new MaterialButton();
            label17 = new Label();
            materialCard1 = new MaterialCard();
            label15 = new Label();
            label16 = new Label();
            materialButton3 = new MaterialButton();
            materialButton4 = new MaterialButton();
            materialButton5 = new MaterialButton();
            materialButton6 = new MaterialButton();
            sideBar.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            dashboardCard.SuspendLayout();
            tabPageAppointments.SuspendLayout();
            calendarCard.SuspendLayout();
            flpAppointmentRequest.SuspendLayout();
            materialCard5.SuspendLayout();
            appointmentCard.SuspendLayout();
            tabPageServices.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            tabPageBarbers.SuspendLayout();
            tabPageReports.SuspendLayout();
            tabPageConfigurations.SuspendLayout();
            materialCard4.SuspendLayout();
            tabPageAvailability.SuspendLayout();
            cardSaturdayAvailability.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            sideBar.BackColor = Color.FromArgb(255, 255, 255);
            sideBar.Controls.Add(mtbRegisterBarberProfile);
            sideBar.Controls.Add(btnBarberAvailabilities);
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
            sideBar.Size = new Size(314, 757);
            sideBar.TabIndex = 11;
            // 
            // mtbRegisterBarberProfile
            // 
            mtbRegisterBarberProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mtbRegisterBarberProfile.AutoSize = false;
            mtbRegisterBarberProfile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtbRegisterBarberProfile.BackColor = SystemColors.Control;
            mtbRegisterBarberProfile.Density = MaterialButton.MaterialButtonDensity.Default;
            mtbRegisterBarberProfile.Depth = 0;
            mtbRegisterBarberProfile.HighEmphasis = true;
            mtbRegisterBarberProfile.Icon = null;
            mtbRegisterBarberProfile.IconType = MaterialButton.MaterialIconType.Rebase;
            mtbRegisterBarberProfile.Location = new Point(13, 556);
            mtbRegisterBarberProfile.Margin = new Padding(4, 6, 4, 6);
            mtbRegisterBarberProfile.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtbRegisterBarberProfile.Name = "mtbRegisterBarberProfile";
            mtbRegisterBarberProfile.NoAccentTextColor = Color.Empty;
            mtbRegisterBarberProfile.Size = new Size(275, 36);
            mtbRegisterBarberProfile.TabIndex = 26;
            mtbRegisterBarberProfile.Text = "Registrar perfil de barbeiro";
            mtbRegisterBarberProfile.Type = MaterialButton.MaterialButtonType.Outlined;
            mtbRegisterBarberProfile.UseAccentColor = false;
            mtbRegisterBarberProfile.UseVisualStyleBackColor = false;
            mtbRegisterBarberProfile.Click += mtbRegisterBarberProfile_Click;
            // 
            // btnBarberAvailabilities
            // 
            btnBarberAvailabilities.BackColor = Color.Transparent;
            btnBarberAvailabilities.BorderColor = Color.Transparent;
            btnBarberAvailabilities.EnteredBorderColor = Color.FromArgb(184, 184, 184);
            btnBarberAvailabilities.EnteredColor = Color.FromArgb(184, 184, 184);
            btnBarberAvailabilities.Font = new Font("Segoe UI", 11F);
            btnBarberAvailabilities.Image = null;
            btnBarberAvailabilities.ImageAlign = ContentAlignment.MiddleLeft;
            btnBarberAvailabilities.InactiveColor = Color.Transparent;
            btnBarberAvailabilities.Location = new Point(26, 282);
            btnBarberAvailabilities.Name = "btnBarberAvailabilities";
            btnBarberAvailabilities.PressedBorderColor = Color.FromArgb(11, 153, 255);
            btnBarberAvailabilities.PressedColor = Color.FromArgb(73, 167, 235);
            btnBarberAvailabilities.Size = new Size(221, 35);
            btnBarberAvailabilities.TabIndex = 25;
            btnBarberAvailabilities.Tag = "7";
            btnBarberAvailabilities.Text = "Disponibilidade";
            btnBarberAvailabilities.TextAlignment = StringAlignment.Near;
            btnBarberAvailabilities.Click += btnBarberAvailabilities_Click;
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
            btnLogout.Density = MaterialButton.MaterialButtonDensity.Default;
            btnLogout.Depth = 0;
            btnLogout.HighEmphasis = true;
            btnLogout.Icon = null;
            btnLogout.IconType = MaterialButton.MaterialIconType.Rebase;
            btnLogout.Location = new Point(155, 691);
            btnLogout.Margin = new Padding(4, 6, 4, 6);
            btnLogout.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogout.Name = "btnLogout";
            btnLogout.NoAccentTextColor = Color.Empty;
            btnLogout.Size = new Size(133, 36);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Sair";
            btnLogout.Type = MaterialButton.MaterialButtonType.Contained;
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
            btnUserAction.Density = MaterialButton.MaterialButtonDensity.Default;
            btnUserAction.Depth = 0;
            btnUserAction.HighEmphasis = true;
            btnUserAction.Icon = null;
            btnUserAction.IconType = MaterialButton.MaterialIconType.Rebase;
            btnUserAction.Location = new Point(13, 691);
            btnUserAction.Margin = new Padding(4, 6, 4, 6);
            btnUserAction.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnUserAction.Name = "btnUserAction";
            btnUserAction.NoAccentTextColor = Color.Empty;
            btnUserAction.Size = new Size(133, 36);
            btnUserAction.TabIndex = 13;
            btnUserAction.Text = "Perfil";
            btnUserAction.Type = MaterialButton.MaterialButtonType.Outlined;
            btnUserAction.UseAccentColor = false;
            btnUserAction.UseVisualStyleBackColor = false;
            btnUserAction.Click += btnUserAction_Click;
            // 
            // lblUserEmail
            // 
            lblUserEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUserEmail.Font = new Font("Segoe UI", 10F);
            lblUserEmail.ForeColor = Color.Gray;
            lblUserEmail.Location = new Point(87, 653);
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
            lblUserName.Location = new Point(87, 619);
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
            parrotButton2.ButtonStyle = ParrotButton.Style.MaterialRounded;
            parrotButton2.ButtonText = "";
            parrotButton2.ClickBackColor = Color.FromArgb(73, 167, 235);
            parrotButton2.ClickTextColor = Color.Black;
            parrotButton2.CornerRadius = 10;
            parrotButton2.Font = new Font("Microsoft Sans Serif", 14F);
            parrotButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotButton2.HoverBackgroundColor = Color.FromArgb(192, 244, 255);
            parrotButton2.HoverTextColor = Color.Black;
            parrotButton2.ImagePosition = ParrotButton.ImgPosition.Left;
            parrotButton2.Location = new Point(26, 619);
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
            separator1.Location = new Point(13, 601);
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
            btnConfigurations.Text = "Perfil";
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
            tabControlMain.Size = new Size(956, 758);
            tabControlMain.TabIndex = 12;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(dashboardCard);
            tabPageDashboard.Location = new Point(4, 29);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(948, 725);
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
            dashboardCard.Size = new Size(914, 106);
            dashboardCard.TabIndex = 25;
            // 
            // btnDashboardNewAppointment
            // 
            btnDashboardNewAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDashboardNewAppointment.AutoSize = false;
            btnDashboardNewAppointment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDashboardNewAppointment.BackColor = SystemColors.Control;
            btnDashboardNewAppointment.Density = MaterialButton.MaterialButtonDensity.Default;
            btnDashboardNewAppointment.Depth = 0;
            btnDashboardNewAppointment.HighEmphasis = true;
            btnDashboardNewAppointment.Icon = Properties.Resources.calendar_plus;
            btnDashboardNewAppointment.IconType = MaterialButton.MaterialIconType.Rebase;
            btnDashboardNewAppointment.Location = new Point(528, 27);
            btnDashboardNewAppointment.Margin = new Padding(4, 6, 4, 6);
            btnDashboardNewAppointment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDashboardNewAppointment.Name = "btnDashboardNewAppointment";
            btnDashboardNewAppointment.NoAccentTextColor = Color.Empty;
            btnDashboardNewAppointment.Size = new Size(193, 49);
            btnDashboardNewAppointment.TabIndex = 26;
            btnDashboardNewAppointment.Text = "Novo Agendamento";
            btnDashboardNewAppointment.Type = MaterialButton.MaterialButtonType.Contained;
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
            btnDashboardNewService.Density = MaterialButton.MaterialButtonDensity.Default;
            btnDashboardNewService.Depth = 0;
            btnDashboardNewService.HighEmphasis = true;
            btnDashboardNewService.Icon = Properties.Resources.barber_pole;
            btnDashboardNewService.IconType = MaterialButton.MaterialIconType.Rebase;
            btnDashboardNewService.Location = new Point(729, 27);
            btnDashboardNewService.Margin = new Padding(4, 6, 4, 6);
            btnDashboardNewService.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDashboardNewService.Name = "btnDashboardNewService";
            btnDashboardNewService.NoAccentTextColor = Color.Empty;
            btnDashboardNewService.Size = new Size(153, 49);
            btnDashboardNewService.TabIndex = 25;
            btnDashboardNewService.Text = "Novo Serviço";
            btnDashboardNewService.Type = MaterialButton.MaterialButtonType.Outlined;
            btnDashboardNewService.UseAccentColor = false;
            btnDashboardNewService.UseVisualStyleBackColor = false;
            btnDashboardNewService.Click += btnDashboardNewService_Click;
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
            tabPageAppointments.Size = new Size(948, 725);
            tabPageAppointments.TabIndex = 1;
            tabPageAppointments.Text = "Appointments";
            tabPageAppointments.UseVisualStyleBackColor = true;
            tabPageAppointments.Enter += tabPageAppointments_Enter;
            // 
            // calendarCard
            // 
            calendarCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calendarCard.BackColor = Color.FromArgb(255, 255, 255);
            calendarCard.Controls.Add(mcbAppointmentStatus);
            calendarCard.Controls.Add(btnConfirmAppointment);
            calendarCard.Controls.Add(flpAppointmentRequest);
            calendarCard.Controls.Add(label45);
            calendarCard.Controls.Add(flpAppointments);
            calendarCard.Controls.Add(label5);
            calendarCard.Controls.Add(label14);
            calendarCard.Depth = 0;
            calendarCard.ForeColor = Color.FromArgb(222, 0, 0, 0);
            calendarCard.Location = new Point(14, 113);
            calendarCard.Margin = new Padding(14);
            calendarCard.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            calendarCard.Name = "calendarCard";
            calendarCard.Padding = new Padding(14);
            calendarCard.Size = new Size(917, 595);
            calendarCard.TabIndex = 28;
            // 
            // mcbAppointmentStatus
            // 
            mcbAppointmentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcbAppointmentStatus.AutoResize = false;
            mcbAppointmentStatus.BackColor = Color.FromArgb(255, 255, 255);
            mcbAppointmentStatus.Depth = 0;
            mcbAppointmentStatus.DrawMode = DrawMode.OwnerDrawVariable;
            mcbAppointmentStatus.DropDownHeight = 174;
            mcbAppointmentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbAppointmentStatus.DropDownWidth = 121;
            mcbAppointmentStatus.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbAppointmentStatus.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbAppointmentStatus.FormattingEnabled = true;
            mcbAppointmentStatus.Hint = "Status";
            mcbAppointmentStatus.IntegralHeight = false;
            mcbAppointmentStatus.ItemHeight = 43;
            mcbAppointmentStatus.Items.AddRange(new object[] { "Sem filtro", "Aguardando aprovação", "Agendado", "Finalizado", "Cancelado" });
            mcbAppointmentStatus.Location = new Point(654, 14);
            mcbAppointmentStatus.MaxDropDownItems = 4;
            mcbAppointmentStatus.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbAppointmentStatus.Name = "mcbAppointmentStatus";
            mcbAppointmentStatus.Size = new Size(245, 49);
            mcbAppointmentStatus.StartIndex = 0;
            mcbAppointmentStatus.TabIndex = 36;
            mcbAppointmentStatus.SelectedIndexChanged += mcbAppointmentStatus_SelectedIndexChanged;
            // 
            // btnConfirmAppointment
            // 
            btnConfirmAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfirmAppointment.AutoSize = false;
            btnConfirmAppointment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmAppointment.BackColor = SystemColors.Control;
            btnConfirmAppointment.Density = MaterialButton.MaterialButtonDensity.Default;
            btnConfirmAppointment.Depth = 0;
            btnConfirmAppointment.HighEmphasis = true;
            btnConfirmAppointment.Icon = null;
            btnConfirmAppointment.IconType = MaterialButton.MaterialIconType.Rebase;
            btnConfirmAppointment.Location = new Point(678, 249);
            btnConfirmAppointment.Margin = new Padding(4, 6, 4, 6);
            btnConfirmAppointment.MaximumSize = new Size(221, 32);
            btnConfirmAppointment.MinimumSize = new Size(221, 32);
            btnConfirmAppointment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnConfirmAppointment.Name = "btnConfirmAppointment";
            btnConfirmAppointment.NoAccentTextColor = Color.Empty;
            btnConfirmAppointment.Size = new Size(221, 32);
            btnConfirmAppointment.TabIndex = 35;
            btnConfirmAppointment.Text = "Confirmar agendamento";
            btnConfirmAppointment.Type = MaterialButton.MaterialButtonType.Outlined;
            btnConfirmAppointment.UseAccentColor = true;
            btnConfirmAppointment.UseVisualStyleBackColor = false;
            btnConfirmAppointment.Click += btnConfirmAppointment_Click;
            // 
            // flpAppointmentRequest
            // 
            flpAppointmentRequest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpAppointmentRequest.AutoScroll = true;
            flpAppointmentRequest.BackColor = Color.White;
            flpAppointmentRequest.Controls.Add(materialCard5);
            flpAppointmentRequest.Location = new Point(17, 290);
            flpAppointmentRequest.Name = "flpAppointmentRequest";
            flpAppointmentRequest.Size = new Size(882, 288);
            flpAppointmentRequest.TabIndex = 34;
            flpAppointmentRequest.WrapContents = false;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(label51);
            materialCard5.Controls.Add(checkBox1);
            materialCard5.Controls.Add(materialButton1);
            materialCard5.Controls.Add(label50);
            materialCard5.Controls.Add(label49);
            materialCard5.Controls.Add(label48);
            materialCard5.Controls.Add(label47);
            materialCard5.Controls.Add(label46);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(14, 14);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(218, 232);
            materialCard5.TabIndex = 0;
            materialCard5.Visible = false;
            // 
            // label51
            // 
            label51.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label51.ForeColor = Color.Black;
            label51.Location = new Point(10, 157);
            label51.Name = "label51";
            label51.Size = new Size(201, 20);
            label51.TabIndex = 41;
            label51.Text = "Aguardando agendamento";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(184, 17);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 40;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSize = false;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton1.Location = new Point(10, 186);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(198, 31);
            materialButton1.TabIndex = 39;
            materialButton1.Text = "Ver mais";
            materialButton1.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            label50.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label50.ForeColor = Color.Black;
            label50.Location = new Point(117, 55);
            label50.Name = "label50";
            label50.Size = new Size(94, 24);
            label50.TabIndex = 38;
            label50.Text = "Sábado";
            // 
            // label49
            // 
            label49.Font = new Font("Segoe UI", 10F);
            label49.ForeColor = Color.Gray;
            label49.Location = new Point(10, 67);
            label49.Name = "label49";
            label49.Size = new Size(101, 24);
            label49.TabIndex = 37;
            label49.Text = "19:00";
            // 
            // label48
            // 
            label48.Font = new Font("Segoe UI", 10F);
            label48.ForeColor = Color.Gray;
            label48.Location = new Point(10, 46);
            label48.Name = "label48";
            label48.Size = new Size(101, 24);
            label48.TabIndex = 36;
            label48.Text = "21/12/2025";
            // 
            // label47
            // 
            label47.Font = new Font("Segoe UI", 10F);
            label47.ForeColor = Color.Black;
            label47.Location = new Point(10, 97);
            label47.Name = "label47";
            label47.Size = new Size(201, 51);
            label47.TabIndex = 35;
            label47.Text = "Cabelo e Barba ";
            // 
            // label46
            // 
            label46.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label46.ForeColor = Color.Black;
            label46.Location = new Point(10, 14);
            label46.Name = "label46";
            label46.Size = new Size(168, 32);
            label46.TabIndex = 35;
            label46.Text = "Jose da silva";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label45.ForeColor = Color.Black;
            label45.Location = new Point(17, 255);
            label45.Name = "label45";
            label45.Size = new Size(397, 32);
            label45.TabIndex = 33;
            label45.Text = "Suas proprostas de agendamento";
            // 
            // flpAppointments
            // 
            flpAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpAppointments.AutoScroll = true;
            flpAppointments.BackColor = Color.White;
            flpAppointments.Location = new Point(17, 72);
            flpAppointments.MaximumSize = new Size(0, 400);
            flpAppointments.Name = "flpAppointments";
            flpAppointments.Size = new Size(882, 215);
            flpAppointments.TabIndex = 32;
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
            appointmentCard.Size = new Size(917, 106);
            appointmentCard.TabIndex = 27;
            // 
            // btnNewAppointment
            // 
            btnNewAppointment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnNewAppointment.AutoSize = false;
            btnNewAppointment.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNewAppointment.BackColor = SystemColors.Control;
            btnNewAppointment.Density = MaterialButton.MaterialButtonDensity.Default;
            btnNewAppointment.Depth = 0;
            btnNewAppointment.HighEmphasis = true;
            btnNewAppointment.Icon = Properties.Resources.calendar_plus;
            btnNewAppointment.IconType = MaterialButton.MaterialIconType.Rebase;
            btnNewAppointment.Location = new Point(706, 32);
            btnNewAppointment.Margin = new Padding(4, 6, 4, 6);
            btnNewAppointment.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNewAppointment.Name = "btnNewAppointment";
            btnNewAppointment.NoAccentTextColor = Color.Empty;
            btnNewAppointment.Size = new Size(193, 49);
            btnNewAppointment.TabIndex = 27;
            btnNewAppointment.Text = "Novo Agendamento";
            btnNewAppointment.Type = MaterialButton.MaterialButtonType.Contained;
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
            tabPageServices.Controls.Add(materialCard3);
            tabPageServices.Controls.Add(flpServiceCardList);
            tabPageServices.Controls.Add(btnApplyFilters);
            tabPageServices.Controls.Add(label23);
            tabPageServices.Controls.Add(mcbPriceOperatorFilter);
            tabPageServices.Controls.Add(mtbPriceFilter);
            tabPageServices.Controls.Add(label22);
            tabPageServices.Controls.Add(mcbDurationOperatorFilter);
            tabPageServices.Controls.Add(mtbDurationFilter);
            tabPageServices.Controls.Add(label20);
            tabPageServices.Controls.Add(btnSearchServices);
            tabPageServices.Controls.Add(mtbServiceName);
            tabPageServices.Controls.Add(materialCard2);
            tabPageServices.Location = new Point(4, 29);
            tabPageServices.Name = "tabPageServices";
            tabPageServices.Padding = new Padding(3);
            tabPageServices.Size = new Size(948, 725);
            tabPageServices.TabIndex = 2;
            tabPageServices.Text = "Services";
            tabPageServices.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            materialCard3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(label29);
            materialCard3.Controls.Add(label28);
            materialCard3.Controls.Add(label27);
            materialCard3.Controls.Add(label26);
            materialCard3.Controls.Add(materialButton2);
            materialCard3.Controls.Add(label25);
            materialCard3.Controls.Add(label24);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(31, 186);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(663, 121);
            materialCard3.TabIndex = 0;
            materialCard3.Visible = false;
            // 
            // label29
            // 
            label29.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10F);
            label29.ForeColor = Color.Black;
            label29.Location = new Point(457, 84);
            label29.Name = "label29";
            label29.Size = new Size(62, 23);
            label29.TabIndex = 44;
            label29.Text = "60 min";
            label29.Visible = false;
            // 
            // label28
            // 
            label28.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10F);
            label28.ForeColor = Color.Gray;
            label28.Location = new Point(457, 61);
            label28.Name = "label28";
            label28.Size = new Size(78, 23);
            label28.TabIndex = 43;
            label28.Text = "Duração:";
            label28.Visible = false;
            // 
            // label27
            // 
            label27.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10F);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(457, 38);
            label27.Name = "label27";
            label27.Size = new Size(74, 23);
            label27.TabIndex = 42;
            label27.Text = "R$ 45,00";
            label27.Visible = false;
            // 
            // label26
            // 
            label26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F);
            label26.ForeColor = Color.Gray;
            label26.Location = new Point(457, 14);
            label26.Name = "label26";
            label26.Size = new Size(57, 23);
            label26.TabIndex = 41;
            label26.Text = "Preço:";
            label26.Visible = false;
            // 
            // materialButton2
            // 
            materialButton2.Anchor = AnchorStyles.Right;
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.ForeColor = Color.Black;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.IconType = MaterialButton.MaterialIconType.Default;
            materialButton2.Location = new Point(554, 38);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(91, 40);
            materialButton2.TabIndex = 41;
            materialButton2.Text = "Agendar";
            materialButton2.Type = MaterialButton.MaterialButtonType.Outlined;
            materialButton2.UseAccentColor = true;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Visible = false;
            // 
            // label25
            // 
            label25.Font = new Font("Segoe UI", 10F);
            label25.ForeColor = Color.Gray;
            label25.Location = new Point(17, 44);
            label25.Name = "label25";
            label25.Size = new Size(429, 46);
            label25.TabIndex = 29;
            label25.Text = "Procure por serviços e veja suas ofertas.";
            label25.Visible = false;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(13, 13);
            label24.Name = "label24";
            label24.Size = new Size(103, 31);
            label24.TabIndex = 29;
            label24.Text = "Serviços";
            label24.Visible = false;
            // 
            // flpServiceCardList
            // 
            flpServiceCardList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpServiceCardList.AutoScroll = true;
            flpServiceCardList.AutoSize = true;
            flpServiceCardList.FlowDirection = FlowDirection.TopDown;
            flpServiceCardList.Location = new Point(18, 186);
            flpServiceCardList.Name = "flpServiceCardList";
            flpServiceCardList.Size = new Size(698, 476);
            flpServiceCardList.TabIndex = 0;
            flpServiceCardList.WrapContents = false;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApplyFilters.AutoSize = false;
            btnApplyFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnApplyFilters.Density = MaterialButton.MaterialButtonDensity.Default;
            btnApplyFilters.Depth = 0;
            btnApplyFilters.ForeColor = Color.Black;
            btnApplyFilters.HighEmphasis = true;
            btnApplyFilters.Icon = null;
            btnApplyFilters.IconType = MaterialButton.MaterialIconType.Default;
            btnApplyFilters.Location = new Point(731, 433);
            btnApplyFilters.Margin = new Padding(4, 6, 4, 6);
            btnApplyFilters.MaximumSize = new Size(200, 40);
            btnApplyFilters.MinimumSize = new Size(200, 40);
            btnApplyFilters.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.NoAccentTextColor = Color.Empty;
            btnApplyFilters.Size = new Size(200, 40);
            btnApplyFilters.TabIndex = 40;
            btnApplyFilters.Text = "Aplicar filtros";
            btnApplyFilters.Type = MaterialButton.MaterialButtonType.Contained;
            btnApplyFilters.UseAccentColor = false;
            btnApplyFilters.UseVisualStyleBackColor = true;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // label23
            // 
            label23.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F);
            label23.ForeColor = Color.Gray;
            label23.Location = new Point(731, 295);
            label23.Name = "label23";
            label23.Size = new Size(57, 23);
            label23.TabIndex = 39;
            label23.Text = "Preço:";
            // 
            // mcbPriceOperatorFilter
            // 
            mcbPriceOperatorFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcbPriceOperatorFilter.AutoResize = false;
            mcbPriceOperatorFilter.BackColor = Color.FromArgb(255, 255, 255);
            mcbPriceOperatorFilter.Depth = 0;
            mcbPriceOperatorFilter.DrawMode = DrawMode.OwnerDrawVariable;
            mcbPriceOperatorFilter.DropDownHeight = 174;
            mcbPriceOperatorFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbPriceOperatorFilter.DropDownWidth = 121;
            mcbPriceOperatorFilter.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbPriceOperatorFilter.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbPriceOperatorFilter.FormattingEnabled = true;
            mcbPriceOperatorFilter.IntegralHeight = false;
            mcbPriceOperatorFilter.ItemHeight = 43;
            mcbPriceOperatorFilter.Items.AddRange(new object[] { "Menor que", "Igual", "Maior que" });
            mcbPriceOperatorFilter.Location = new Point(731, 375);
            mcbPriceOperatorFilter.MaxDropDownItems = 4;
            mcbPriceOperatorFilter.MaximumSize = new Size(200, 0);
            mcbPriceOperatorFilter.MinimumSize = new Size(200, 0);
            mcbPriceOperatorFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbPriceOperatorFilter.Name = "mcbPriceOperatorFilter";
            mcbPriceOperatorFilter.Size = new Size(200, 49);
            mcbPriceOperatorFilter.StartIndex = 0;
            mcbPriceOperatorFilter.TabIndex = 38;
            // 
            // mtbPriceFilter
            // 
            mtbPriceFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mtbPriceFilter.AnimateReadOnly = false;
            mtbPriceFilter.AutoCompleteMode = AutoCompleteMode.None;
            mtbPriceFilter.AutoCompleteSource = AutoCompleteSource.None;
            mtbPriceFilter.BackgroundImageLayout = ImageLayout.None;
            mtbPriceFilter.CharacterCasing = CharacterCasing.Normal;
            mtbPriceFilter.Depth = 0;
            mtbPriceFilter.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbPriceFilter.HideSelection = true;
            mtbPriceFilter.Hint = "Preço em R$";
            mtbPriceFilter.LeadingIcon = null;
            mtbPriceFilter.Location = new Point(731, 321);
            mtbPriceFilter.MaximumSize = new Size(200, 48);
            mtbPriceFilter.MaxLength = 32767;
            mtbPriceFilter.MinimumSize = new Size(200, 48);
            mtbPriceFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbPriceFilter.Name = "mtbPriceFilter";
            mtbPriceFilter.PasswordChar = '\0';
            mtbPriceFilter.PrefixSuffixText = null;
            mtbPriceFilter.ReadOnly = false;
            mtbPriceFilter.RightToLeft = RightToLeft.No;
            mtbPriceFilter.SelectedText = "";
            mtbPriceFilter.SelectionLength = 0;
            mtbPriceFilter.SelectionStart = 0;
            mtbPriceFilter.ShortcutsEnabled = true;
            mtbPriceFilter.Size = new Size(200, 48);
            mtbPriceFilter.TabIndex = 37;
            mtbPriceFilter.TabStop = false;
            mtbPriceFilter.TextAlign = HorizontalAlignment.Left;
            mtbPriceFilter.TrailingIcon = null;
            mtbPriceFilter.UseSystemPasswordChar = false;
            mtbPriceFilter.KeyPress += mtbFilter_KeyPress;
            mtbPriceFilter.Leave += mtbPriceFilter_Leave;
            mtbPriceFilter.TextChanged += mtbFilter_TextChanged;
            // 
            // label22
            // 
            label22.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.ForeColor = Color.Gray;
            label22.Location = new Point(731, 163);
            label22.Name = "label22";
            label22.Size = new Size(78, 23);
            label22.TabIndex = 36;
            label22.Text = "Duração:";
            // 
            // mcbDurationOperatorFilter
            // 
            mcbDurationOperatorFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcbDurationOperatorFilter.AutoResize = false;
            mcbDurationOperatorFilter.BackColor = Color.FromArgb(255, 255, 255);
            mcbDurationOperatorFilter.Depth = 0;
            mcbDurationOperatorFilter.DrawMode = DrawMode.OwnerDrawVariable;
            mcbDurationOperatorFilter.DropDownHeight = 174;
            mcbDurationOperatorFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            mcbDurationOperatorFilter.DropDownWidth = 121;
            mcbDurationOperatorFilter.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            mcbDurationOperatorFilter.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcbDurationOperatorFilter.FormattingEnabled = true;
            mcbDurationOperatorFilter.IntegralHeight = false;
            mcbDurationOperatorFilter.ItemHeight = 43;
            mcbDurationOperatorFilter.Items.AddRange(new object[] { "Menor que", "Igual", "Maior que" });
            mcbDurationOperatorFilter.Location = new Point(731, 243);
            mcbDurationOperatorFilter.MaxDropDownItems = 4;
            mcbDurationOperatorFilter.MaximumSize = new Size(200, 0);
            mcbDurationOperatorFilter.MinimumSize = new Size(200, 0);
            mcbDurationOperatorFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mcbDurationOperatorFilter.Name = "mcbDurationOperatorFilter";
            mcbDurationOperatorFilter.Size = new Size(200, 49);
            mcbDurationOperatorFilter.StartIndex = 0;
            mcbDurationOperatorFilter.TabIndex = 35;
            // 
            // mtbDurationFilter
            // 
            mtbDurationFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mtbDurationFilter.AnimateReadOnly = false;
            mtbDurationFilter.AutoCompleteMode = AutoCompleteMode.None;
            mtbDurationFilter.AutoCompleteSource = AutoCompleteSource.None;
            mtbDurationFilter.BackgroundImageLayout = ImageLayout.None;
            mtbDurationFilter.CharacterCasing = CharacterCasing.Normal;
            mtbDurationFilter.Depth = 0;
            mtbDurationFilter.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbDurationFilter.HideSelection = true;
            mtbDurationFilter.Hint = "Duração em Minutos";
            mtbDurationFilter.LeadingIcon = null;
            mtbDurationFilter.Location = new Point(731, 189);
            mtbDurationFilter.MaximumSize = new Size(200, 48);
            mtbDurationFilter.MaxLength = 32767;
            mtbDurationFilter.MinimumSize = new Size(200, 48);
            mtbDurationFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbDurationFilter.Name = "mtbDurationFilter";
            mtbDurationFilter.PasswordChar = '\0';
            mtbDurationFilter.PrefixSuffixText = null;
            mtbDurationFilter.ReadOnly = false;
            mtbDurationFilter.RightToLeft = RightToLeft.No;
            mtbDurationFilter.SelectedText = "";
            mtbDurationFilter.SelectionLength = 0;
            mtbDurationFilter.SelectionStart = 0;
            mtbDurationFilter.ShortcutsEnabled = true;
            mtbDurationFilter.Size = new Size(200, 48);
            mtbDurationFilter.TabIndex = 34;
            mtbDurationFilter.TabStop = false;
            mtbDurationFilter.TextAlign = HorizontalAlignment.Left;
            mtbDurationFilter.TrailingIcon = null;
            mtbDurationFilter.UseSystemPasswordChar = false;
            mtbDurationFilter.KeyPress += mtbFilter_KeyPress;
            mtbDurationFilter.TextChanged += mtbFilter_TextChanged;
            // 
            // label20
            // 
            label20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(731, 132);
            label20.Name = "label20";
            label20.Size = new Size(59, 23);
            label20.TabIndex = 33;
            label20.Text = "Filtros:";
            // 
            // btnSearchServices
            // 
            btnSearchServices.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchServices.AutoSize = false;
            btnSearchServices.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchServices.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSearchServices.Depth = 0;
            btnSearchServices.ForeColor = Color.Black;
            btnSearchServices.HighEmphasis = true;
            btnSearchServices.Icon = Properties.Resources.search;
            btnSearchServices.IconType = MaterialButton.MaterialIconType.Default;
            btnSearchServices.Location = new Point(670, 132);
            btnSearchServices.Margin = new Padding(4, 6, 4, 6);
            btnSearchServices.MaximumSize = new Size(46, 40);
            btnSearchServices.MinimumSize = new Size(46, 40);
            btnSearchServices.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSearchServices.Name = "btnSearchServices";
            btnSearchServices.NoAccentTextColor = Color.Empty;
            btnSearchServices.Size = new Size(46, 40);
            btnSearchServices.TabIndex = 32;
            btnSearchServices.Type = MaterialButton.MaterialButtonType.Contained;
            btnSearchServices.UseAccentColor = false;
            btnSearchServices.UseVisualStyleBackColor = true;
            btnSearchServices.Click += btnSearchServices_Click;
            // 
            // mtbServiceName
            // 
            mtbServiceName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtbServiceName.AnimateReadOnly = false;
            mtbServiceName.AutoCompleteMode = AutoCompleteMode.None;
            mtbServiceName.AutoCompleteSource = AutoCompleteSource.None;
            mtbServiceName.BackgroundImageLayout = ImageLayout.None;
            mtbServiceName.CharacterCasing = CharacterCasing.Normal;
            mtbServiceName.Depth = 0;
            mtbServiceName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbServiceName.HideSelection = true;
            mtbServiceName.Hint = "Insira o nome do serviço ou parte dele.";
            mtbServiceName.LeadingIcon = null;
            mtbServiceName.Location = new Point(16, 129);
            mtbServiceName.MaxLength = 32767;
            mtbServiceName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbServiceName.Name = "mtbServiceName";
            mtbServiceName.PasswordChar = '\0';
            mtbServiceName.PrefixSuffixText = null;
            mtbServiceName.ReadOnly = false;
            mtbServiceName.RightToLeft = RightToLeft.No;
            mtbServiceName.SelectedText = "";
            mtbServiceName.SelectionLength = 0;
            mtbServiceName.SelectionStart = 0;
            mtbServiceName.ShortcutsEnabled = true;
            mtbServiceName.Size = new Size(646, 48);
            mtbServiceName.TabIndex = 31;
            mtbServiceName.TabStop = false;
            mtbServiceName.TextAlign = HorizontalAlignment.Left;
            mtbServiceName.TrailingIcon = null;
            mtbServiceName.UseSystemPasswordChar = false;
            mtbServiceName.KeyPress += mtbServiceName_KeyPress;
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(mtbNewService);
            materialCard2.Controls.Add(label7);
            materialCard2.Controls.Add(label19);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 10);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(917, 106);
            materialCard2.TabIndex = 28;
            // 
            // mtbNewService
            // 
            mtbNewService.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            mtbNewService.AutoSize = false;
            mtbNewService.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtbNewService.BackColor = SystemColors.Control;
            mtbNewService.Density = MaterialButton.MaterialButtonDensity.Default;
            mtbNewService.Depth = 0;
            mtbNewService.HighEmphasis = true;
            mtbNewService.Icon = Properties.Resources.barber_pole;
            mtbNewService.IconType = MaterialButton.MaterialIconType.Rebase;
            mtbNewService.Location = new Point(729, 27);
            mtbNewService.Margin = new Padding(4, 6, 4, 6);
            mtbNewService.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtbNewService.Name = "mtbNewService";
            mtbNewService.NoAccentTextColor = Color.Empty;
            mtbNewService.Size = new Size(153, 49);
            mtbNewService.TabIndex = 28;
            mtbNewService.Text = "Novo Serviço";
            mtbNewService.Type = MaterialButton.MaterialButtonType.Outlined;
            mtbNewService.UseAccentColor = false;
            mtbNewService.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(17, 61);
            label7.Name = "label7";
            label7.Size = new Size(312, 23);
            label7.TabIndex = 25;
            label7.Text = "Procure por serviços e veja suas ofertas.";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Black;
            label19.Location = new Point(17, 14);
            label19.Name = "label19";
            label19.Size = new Size(125, 38);
            label19.TabIndex = 25;
            label19.Text = "Serviços";
            // 
            // tabPageBarbers
            // 
            tabPageBarbers.Controls.Add(label8);
            tabPageBarbers.Location = new Point(4, 29);
            tabPageBarbers.Name = "tabPageBarbers";
            tabPageBarbers.Padding = new Padding(3);
            tabPageBarbers.Size = new Size(948, 725);
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
            tabPageReports.Size = new Size(948, 725);
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
            tabPageConfigurations.Controls.Add(btnSaveBarberChanges);
            tabPageConfigurations.Controls.Add(mchbBarberEditMode);
            tabPageConfigurations.Controls.Add(mtbBarberAddress);
            tabPageConfigurations.Controls.Add(label44);
            tabPageConfigurations.Controls.Add(mtbBarberAddressCity);
            tabPageConfigurations.Controls.Add(label43);
            tabPageConfigurations.Controls.Add(mtbBarberAddressState);
            tabPageConfigurations.Controls.Add(label42);
            tabPageConfigurations.Controls.Add(mtbBarberAddressCountry);
            tabPageConfigurations.Controls.Add(label41);
            tabPageConfigurations.Controls.Add(mtbBarberAddressNumber);
            tabPageConfigurations.Controls.Add(label40);
            tabPageConfigurations.Controls.Add(mtbBarberCep);
            tabPageConfigurations.Controls.Add(label39);
            tabPageConfigurations.Controls.Add(label38);
            tabPageConfigurations.Controls.Add(mtbBarberPortifolioUrl);
            tabPageConfigurations.Controls.Add(label37);
            tabPageConfigurations.Controls.Add(mrtbBarberDescription);
            tabPageConfigurations.Controls.Add(label36);
            tabPageConfigurations.Controls.Add(btnSaveProfileChanges);
            tabPageConfigurations.Controls.Add(mchbProfileEditMode);
            tabPageConfigurations.Controls.Add(mtbProfilePromotionPoints);
            tabPageConfigurations.Controls.Add(label35);
            tabPageConfigurations.Controls.Add(mtbProfilePhoneNumber);
            tabPageConfigurations.Controls.Add(label34);
            tabPageConfigurations.Controls.Add(mtbProfileEmail);
            tabPageConfigurations.Controls.Add(label33);
            tabPageConfigurations.Controls.Add(materialCard4);
            tabPageConfigurations.Controls.Add(mtbProfileName);
            tabPageConfigurations.Controls.Add(label32);
            tabPageConfigurations.Controls.Add(label31);
            tabPageConfigurations.Location = new Point(4, 29);
            tabPageConfigurations.Name = "tabPageConfigurations";
            tabPageConfigurations.Padding = new Padding(3);
            tabPageConfigurations.Size = new Size(948, 725);
            tabPageConfigurations.TabIndex = 5;
            tabPageConfigurations.Text = "Configurations";
            tabPageConfigurations.UseVisualStyleBackColor = true;
            // 
            // btnSaveBarberChanges
            // 
            btnSaveBarberChanges.AutoSize = false;
            btnSaveBarberChanges.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveBarberChanges.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSaveBarberChanges.Depth = 0;
            btnSaveBarberChanges.HighEmphasis = true;
            btnSaveBarberChanges.Icon = null;
            btnSaveBarberChanges.IconType = MaterialButton.MaterialIconType.Rebase;
            btnSaveBarberChanges.Location = new Point(364, 598);
            btnSaveBarberChanges.Margin = new Padding(4, 6, 4, 6);
            btnSaveBarberChanges.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSaveBarberChanges.Name = "btnSaveBarberChanges";
            btnSaveBarberChanges.NoAccentTextColor = Color.Empty;
            btnSaveBarberChanges.Size = new Size(264, 37);
            btnSaveBarberChanges.TabIndex = 56;
            btnSaveBarberChanges.Text = "Salvar Alterações Barbeiro";
            btnSaveBarberChanges.Type = MaterialButton.MaterialButtonType.Contained;
            btnSaveBarberChanges.UseAccentColor = false;
            btnSaveBarberChanges.UseVisualStyleBackColor = true;
            btnSaveBarberChanges.Click += btnSaveBarberChanges_Click;
            // 
            // mchbBarberEditMode
            // 
            mchbBarberEditMode.AutoSize = true;
            mchbBarberEditMode.Depth = 0;
            mchbBarberEditMode.Location = new Point(364, 555);
            mchbBarberEditMode.Margin = new Padding(0);
            mchbBarberEditMode.MouseLocation = new Point(-1, -1);
            mchbBarberEditMode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mchbBarberEditMode.Name = "mchbBarberEditMode";
            mchbBarberEditMode.ReadOnly = false;
            mchbBarberEditMode.Ripple = true;
            mchbBarberEditMode.Size = new Size(191, 37);
            mchbBarberEditMode.TabIndex = 55;
            mchbBarberEditMode.Text = "Modo Edição Barbeiro";
            mchbBarberEditMode.UseAccentColor = false;
            mchbBarberEditMode.UseVisualStyleBackColor = true;
            mchbBarberEditMode.CheckedChanged += mchbBarberEditMode_CheckedChanged;
            // 
            // mtbBarberAddress
            // 
            mtbBarberAddress.AnimateReadOnly = false;
            mtbBarberAddress.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberAddress.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberAddress.BackgroundImageLayout = ImageLayout.None;
            mtbBarberAddress.CharacterCasing = CharacterCasing.Normal;
            mtbBarberAddress.Depth = 0;
            mtbBarberAddress.Enabled = false;
            mtbBarberAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberAddress.HideSelection = true;
            mtbBarberAddress.LeadingIcon = null;
            mtbBarberAddress.Location = new Point(687, 472);
            mtbBarberAddress.MaxLength = 32767;
            mtbBarberAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberAddress.Name = "mtbBarberAddress";
            mtbBarberAddress.PasswordChar = '\0';
            mtbBarberAddress.PrefixSuffixText = null;
            mtbBarberAddress.ReadOnly = true;
            mtbBarberAddress.RightToLeft = RightToLeft.No;
            mtbBarberAddress.SelectedText = "";
            mtbBarberAddress.SelectionLength = 0;
            mtbBarberAddress.SelectionStart = 0;
            mtbBarberAddress.ShortcutsEnabled = true;
            mtbBarberAddress.Size = new Size(244, 48);
            mtbBarberAddress.TabIndex = 54;
            mtbBarberAddress.TabStop = false;
            mtbBarberAddress.TextAlign = HorizontalAlignment.Left;
            mtbBarberAddress.TrailingIcon = null;
            mtbBarberAddress.UseSystemPasswordChar = false;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 10F);
            label44.ForeColor = Color.Gray;
            label44.Location = new Point(687, 446);
            label44.Name = "label44";
            label44.Size = new Size(81, 23);
            label44.TabIndex = 53;
            label44.Text = "Endereço";
            // 
            // mtbBarberAddressCity
            // 
            mtbBarberAddressCity.AnimateReadOnly = false;
            mtbBarberAddressCity.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberAddressCity.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberAddressCity.BackgroundImageLayout = ImageLayout.None;
            mtbBarberAddressCity.CharacterCasing = CharacterCasing.Normal;
            mtbBarberAddressCity.Depth = 0;
            mtbBarberAddressCity.Enabled = false;
            mtbBarberAddressCity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberAddressCity.HideSelection = true;
            mtbBarberAddressCity.LeadingIcon = null;
            mtbBarberAddressCity.Location = new Point(687, 386);
            mtbBarberAddressCity.MaxLength = 32767;
            mtbBarberAddressCity.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberAddressCity.Name = "mtbBarberAddressCity";
            mtbBarberAddressCity.PasswordChar = '\0';
            mtbBarberAddressCity.PrefixSuffixText = null;
            mtbBarberAddressCity.ReadOnly = true;
            mtbBarberAddressCity.RightToLeft = RightToLeft.No;
            mtbBarberAddressCity.SelectedText = "";
            mtbBarberAddressCity.SelectionLength = 0;
            mtbBarberAddressCity.SelectionStart = 0;
            mtbBarberAddressCity.ShortcutsEnabled = true;
            mtbBarberAddressCity.Size = new Size(244, 48);
            mtbBarberAddressCity.TabIndex = 52;
            mtbBarberAddressCity.TabStop = false;
            mtbBarberAddressCity.TextAlign = HorizontalAlignment.Left;
            mtbBarberAddressCity.TrailingIcon = null;
            mtbBarberAddressCity.UseSystemPasswordChar = false;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 10F);
            label43.ForeColor = Color.Gray;
            label43.Location = new Point(687, 360);
            label43.Name = "label43";
            label43.Size = new Size(67, 23);
            label43.TabIndex = 51;
            label43.Text = "Cidade:";
            // 
            // mtbBarberAddressState
            // 
            mtbBarberAddressState.AnimateReadOnly = false;
            mtbBarberAddressState.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberAddressState.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberAddressState.BackgroundImageLayout = ImageLayout.None;
            mtbBarberAddressState.CharacterCasing = CharacterCasing.Normal;
            mtbBarberAddressState.Depth = 0;
            mtbBarberAddressState.Enabled = false;
            mtbBarberAddressState.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberAddressState.HideSelection = true;
            mtbBarberAddressState.LeadingIcon = null;
            mtbBarberAddressState.Location = new Point(687, 301);
            mtbBarberAddressState.MaxLength = 32767;
            mtbBarberAddressState.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberAddressState.Name = "mtbBarberAddressState";
            mtbBarberAddressState.PasswordChar = '\0';
            mtbBarberAddressState.PrefixSuffixText = null;
            mtbBarberAddressState.ReadOnly = true;
            mtbBarberAddressState.RightToLeft = RightToLeft.No;
            mtbBarberAddressState.SelectedText = "";
            mtbBarberAddressState.SelectionLength = 0;
            mtbBarberAddressState.SelectionStart = 0;
            mtbBarberAddressState.ShortcutsEnabled = true;
            mtbBarberAddressState.Size = new Size(244, 48);
            mtbBarberAddressState.TabIndex = 50;
            mtbBarberAddressState.TabStop = false;
            mtbBarberAddressState.TextAlign = HorizontalAlignment.Left;
            mtbBarberAddressState.TrailingIcon = null;
            mtbBarberAddressState.UseSystemPasswordChar = false;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 10F);
            label42.ForeColor = Color.Gray;
            label42.Location = new Point(687, 275);
            label42.Name = "label42";
            label42.Size = new Size(65, 23);
            label42.TabIndex = 49;
            label42.Text = "Estado:";
            // 
            // mtbBarberAddressCountry
            // 
            mtbBarberAddressCountry.AnimateReadOnly = false;
            mtbBarberAddressCountry.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberAddressCountry.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberAddressCountry.BackgroundImageLayout = ImageLayout.None;
            mtbBarberAddressCountry.CharacterCasing = CharacterCasing.Normal;
            mtbBarberAddressCountry.Depth = 0;
            mtbBarberAddressCountry.Enabled = false;
            mtbBarberAddressCountry.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberAddressCountry.HideSelection = true;
            mtbBarberAddressCountry.LeadingIcon = null;
            mtbBarberAddressCountry.Location = new Point(687, 218);
            mtbBarberAddressCountry.MaxLength = 32767;
            mtbBarberAddressCountry.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberAddressCountry.Name = "mtbBarberAddressCountry";
            mtbBarberAddressCountry.PasswordChar = '\0';
            mtbBarberAddressCountry.PrefixSuffixText = null;
            mtbBarberAddressCountry.ReadOnly = true;
            mtbBarberAddressCountry.RightToLeft = RightToLeft.No;
            mtbBarberAddressCountry.SelectedText = "";
            mtbBarberAddressCountry.SelectionLength = 0;
            mtbBarberAddressCountry.SelectionStart = 0;
            mtbBarberAddressCountry.ShortcutsEnabled = true;
            mtbBarberAddressCountry.Size = new Size(244, 48);
            mtbBarberAddressCountry.TabIndex = 48;
            mtbBarberAddressCountry.TabStop = false;
            mtbBarberAddressCountry.TextAlign = HorizontalAlignment.Left;
            mtbBarberAddressCountry.TrailingIcon = null;
            mtbBarberAddressCountry.UseSystemPasswordChar = false;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 10F);
            label41.ForeColor = Color.Gray;
            label41.Location = new Point(687, 192);
            label41.Name = "label41";
            label41.Size = new Size(43, 23);
            label41.TabIndex = 47;
            label41.Text = "País:";
            // 
            // mtbBarberAddressNumber
            // 
            mtbBarberAddressNumber.AnimateReadOnly = false;
            mtbBarberAddressNumber.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberAddressNumber.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberAddressNumber.BackgroundImageLayout = ImageLayout.None;
            mtbBarberAddressNumber.CharacterCasing = CharacterCasing.Normal;
            mtbBarberAddressNumber.Depth = 0;
            mtbBarberAddressNumber.Enabled = false;
            mtbBarberAddressNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberAddressNumber.HideSelection = true;
            mtbBarberAddressNumber.LeadingIcon = null;
            mtbBarberAddressNumber.Location = new Point(551, 472);
            mtbBarberAddressNumber.MaxLength = 32767;
            mtbBarberAddressNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberAddressNumber.Name = "mtbBarberAddressNumber";
            mtbBarberAddressNumber.PasswordChar = '\0';
            mtbBarberAddressNumber.PrefixSuffixText = null;
            mtbBarberAddressNumber.ReadOnly = true;
            mtbBarberAddressNumber.RightToLeft = RightToLeft.No;
            mtbBarberAddressNumber.SelectedText = "";
            mtbBarberAddressNumber.SelectionLength = 0;
            mtbBarberAddressNumber.SelectionStart = 0;
            mtbBarberAddressNumber.ShortcutsEnabled = true;
            mtbBarberAddressNumber.Size = new Size(119, 48);
            mtbBarberAddressNumber.TabIndex = 46;
            mtbBarberAddressNumber.TabStop = false;
            mtbBarberAddressNumber.TextAlign = HorizontalAlignment.Left;
            mtbBarberAddressNumber.TrailingIcon = null;
            mtbBarberAddressNumber.UseSystemPasswordChar = false;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 10F);
            label40.ForeColor = Color.Gray;
            label40.Location = new Point(551, 446);
            label40.Name = "label40";
            label40.Size = new Size(77, 23);
            label40.TabIndex = 45;
            label40.Text = "Numero:";
            // 
            // mtbBarberCep
            // 
            mtbBarberCep.AnimateReadOnly = false;
            mtbBarberCep.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberCep.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberCep.BackgroundImageLayout = ImageLayout.None;
            mtbBarberCep.CharacterCasing = CharacterCasing.Normal;
            mtbBarberCep.Depth = 0;
            mtbBarberCep.Enabled = false;
            mtbBarberCep.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberCep.HideSelection = true;
            mtbBarberCep.LeadingIcon = null;
            mtbBarberCep.Location = new Point(364, 472);
            mtbBarberCep.MaxLength = 32767;
            mtbBarberCep.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberCep.Name = "mtbBarberCep";
            mtbBarberCep.PasswordChar = '\0';
            mtbBarberCep.PrefixSuffixText = null;
            mtbBarberCep.ReadOnly = true;
            mtbBarberCep.RightToLeft = RightToLeft.No;
            mtbBarberCep.SelectedText = "";
            mtbBarberCep.SelectionLength = 0;
            mtbBarberCep.SelectionStart = 0;
            mtbBarberCep.ShortcutsEnabled = true;
            mtbBarberCep.Size = new Size(181, 48);
            mtbBarberCep.TabIndex = 44;
            mtbBarberCep.TabStop = false;
            mtbBarberCep.TextAlign = HorizontalAlignment.Left;
            mtbBarberCep.TrailingIcon = null;
            mtbBarberCep.UseSystemPasswordChar = false;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 10F);
            label39.ForeColor = Color.Gray;
            label39.Location = new Point(364, 446);
            label39.Name = "label39";
            label39.Size = new Size(44, 23);
            label39.TabIndex = 43;
            label39.Text = "Cep:";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 10F);
            label38.ForeColor = Color.Gray;
            label38.Location = new Point(364, 192);
            label38.Name = "label38";
            label38.Size = new Size(87, 23);
            label38.TabIndex = 42;
            label38.Text = "Descrição:";
            // 
            // mtbBarberPortifolioUrl
            // 
            mtbBarberPortifolioUrl.AnimateReadOnly = false;
            mtbBarberPortifolioUrl.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberPortifolioUrl.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberPortifolioUrl.BackgroundImageLayout = ImageLayout.None;
            mtbBarberPortifolioUrl.CharacterCasing = CharacterCasing.Normal;
            mtbBarberPortifolioUrl.Depth = 0;
            mtbBarberPortifolioUrl.Enabled = false;
            mtbBarberPortifolioUrl.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberPortifolioUrl.HideSelection = true;
            mtbBarberPortifolioUrl.LeadingIcon = null;
            mtbBarberPortifolioUrl.Location = new Point(364, 386);
            mtbBarberPortifolioUrl.MaxLength = 32767;
            mtbBarberPortifolioUrl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberPortifolioUrl.Name = "mtbBarberPortifolioUrl";
            mtbBarberPortifolioUrl.PasswordChar = '\0';
            mtbBarberPortifolioUrl.PrefixSuffixText = null;
            mtbBarberPortifolioUrl.ReadOnly = true;
            mtbBarberPortifolioUrl.RightToLeft = RightToLeft.No;
            mtbBarberPortifolioUrl.SelectedText = "";
            mtbBarberPortifolioUrl.SelectionLength = 0;
            mtbBarberPortifolioUrl.SelectionStart = 0;
            mtbBarberPortifolioUrl.ShortcutsEnabled = true;
            mtbBarberPortifolioUrl.Size = new Size(306, 48);
            mtbBarberPortifolioUrl.TabIndex = 41;
            mtbBarberPortifolioUrl.TabStop = false;
            mtbBarberPortifolioUrl.TextAlign = HorizontalAlignment.Left;
            mtbBarberPortifolioUrl.TrailingIcon = null;
            mtbBarberPortifolioUrl.UseSystemPasswordChar = false;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 10F);
            label37.ForeColor = Color.Gray;
            label37.Location = new Point(364, 360);
            label37.Name = "label37";
            label37.Size = new Size(109, 23);
            label37.TabIndex = 40;
            label37.Text = "Portifólio Url:";
            // 
            // mrtbBarberDescription
            // 
            mrtbBarberDescription.BackColor = Color.FromArgb(255, 255, 255);
            mrtbBarberDescription.BorderStyle = BorderStyle.None;
            mrtbBarberDescription.Depth = 0;
            mrtbBarberDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mrtbBarberDescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mrtbBarberDescription.Hint = "";
            mrtbBarberDescription.Location = new Point(364, 218);
            mrtbBarberDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mrtbBarberDescription.Name = "mrtbBarberDescription";
            mrtbBarberDescription.ReadOnly = true;
            mrtbBarberDescription.Size = new Size(306, 131);
            mrtbBarberDescription.TabIndex = 39;
            mrtbBarberDescription.Text = "";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(364, 143);
            label36.Name = "label36";
            label36.Size = new Size(279, 31);
            label36.TabIndex = 38;
            label36.Text = "Informações do Barbeiro";
            // 
            // btnSaveProfileChanges
            // 
            btnSaveProfileChanges.AutoSize = false;
            btnSaveProfileChanges.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveProfileChanges.Density = MaterialButton.MaterialButtonDensity.Default;
            btnSaveProfileChanges.Depth = 0;
            btnSaveProfileChanges.HighEmphasis = true;
            btnSaveProfileChanges.Icon = null;
            btnSaveProfileChanges.IconType = MaterialButton.MaterialIconType.Rebase;
            btnSaveProfileChanges.Location = new Point(31, 598);
            btnSaveProfileChanges.Margin = new Padding(4, 6, 4, 6);
            btnSaveProfileChanges.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSaveProfileChanges.Name = "btnSaveProfileChanges";
            btnSaveProfileChanges.NoAccentTextColor = Color.Empty;
            btnSaveProfileChanges.Size = new Size(198, 37);
            btnSaveProfileChanges.TabIndex = 37;
            btnSaveProfileChanges.Text = "Salvar Alterações";
            btnSaveProfileChanges.Type = MaterialButton.MaterialButtonType.Contained;
            btnSaveProfileChanges.UseAccentColor = false;
            btnSaveProfileChanges.UseVisualStyleBackColor = true;
            btnSaveProfileChanges.Click += btnSaveProfileChanges_Click;
            // 
            // mchbProfileEditMode
            // 
            mchbProfileEditMode.AutoSize = true;
            mchbProfileEditMode.Depth = 0;
            mchbProfileEditMode.Location = new Point(31, 555);
            mchbProfileEditMode.Margin = new Padding(0);
            mchbProfileEditMode.MouseLocation = new Point(-1, -1);
            mchbProfileEditMode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mchbProfileEditMode.Name = "mchbProfileEditMode";
            mchbProfileEditMode.ReadOnly = false;
            mchbProfileEditMode.Ripple = true;
            mchbProfileEditMode.Size = new Size(128, 37);
            mchbProfileEditMode.TabIndex = 36;
            mchbProfileEditMode.Text = "Modo Edição";
            mchbProfileEditMode.UseAccentColor = false;
            mchbProfileEditMode.UseVisualStyleBackColor = true;
            mchbProfileEditMode.CheckedChanged += mchbProfileEditMode_CheckedChanged;
            // 
            // mtbProfilePromotionPoints
            // 
            mtbProfilePromotionPoints.AnimateReadOnly = false;
            mtbProfilePromotionPoints.AutoCompleteMode = AutoCompleteMode.None;
            mtbProfilePromotionPoints.AutoCompleteSource = AutoCompleteSource.None;
            mtbProfilePromotionPoints.BackgroundImageLayout = ImageLayout.None;
            mtbProfilePromotionPoints.CharacterCasing = CharacterCasing.Normal;
            mtbProfilePromotionPoints.Depth = 0;
            mtbProfilePromotionPoints.Enabled = false;
            mtbProfilePromotionPoints.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbProfilePromotionPoints.HideSelection = true;
            mtbProfilePromotionPoints.LeadingIcon = null;
            mtbProfilePromotionPoints.Location = new Point(31, 472);
            mtbProfilePromotionPoints.MaxLength = 32767;
            mtbProfilePromotionPoints.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbProfilePromotionPoints.Name = "mtbProfilePromotionPoints";
            mtbProfilePromotionPoints.PasswordChar = '\0';
            mtbProfilePromotionPoints.PrefixSuffixText = null;
            mtbProfilePromotionPoints.ReadOnly = true;
            mtbProfilePromotionPoints.RightToLeft = RightToLeft.No;
            mtbProfilePromotionPoints.SelectedText = "";
            mtbProfilePromotionPoints.SelectionLength = 0;
            mtbProfilePromotionPoints.SelectionStart = 0;
            mtbProfilePromotionPoints.ShortcutsEnabled = true;
            mtbProfilePromotionPoints.Size = new Size(306, 48);
            mtbProfilePromotionPoints.TabIndex = 35;
            mtbProfilePromotionPoints.TabStop = false;
            mtbProfilePromotionPoints.TextAlign = HorizontalAlignment.Left;
            mtbProfilePromotionPoints.TrailingIcon = null;
            mtbProfilePromotionPoints.UseSystemPasswordChar = false;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 10F);
            label35.ForeColor = Color.Gray;
            label35.Location = new Point(31, 446);
            label35.Name = "label35";
            label35.Size = new Size(172, 23);
            label35.TabIndex = 34;
            label35.Text = "Pontos de Fidelidade:";
            // 
            // mtbProfilePhoneNumber
            // 
            mtbProfilePhoneNumber.AnimateReadOnly = false;
            mtbProfilePhoneNumber.AutoCompleteMode = AutoCompleteMode.None;
            mtbProfilePhoneNumber.AutoCompleteSource = AutoCompleteSource.None;
            mtbProfilePhoneNumber.BackgroundImageLayout = ImageLayout.None;
            mtbProfilePhoneNumber.CharacterCasing = CharacterCasing.Normal;
            mtbProfilePhoneNumber.Depth = 0;
            mtbProfilePhoneNumber.Enabled = false;
            mtbProfilePhoneNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbProfilePhoneNumber.HideSelection = true;
            mtbProfilePhoneNumber.LeadingIcon = null;
            mtbProfilePhoneNumber.Location = new Point(31, 386);
            mtbProfilePhoneNumber.MaxLength = 32767;
            mtbProfilePhoneNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbProfilePhoneNumber.Name = "mtbProfilePhoneNumber";
            mtbProfilePhoneNumber.PasswordChar = '\0';
            mtbProfilePhoneNumber.PrefixSuffixText = null;
            mtbProfilePhoneNumber.ReadOnly = true;
            mtbProfilePhoneNumber.RightToLeft = RightToLeft.No;
            mtbProfilePhoneNumber.SelectedText = "";
            mtbProfilePhoneNumber.SelectionLength = 0;
            mtbProfilePhoneNumber.SelectionStart = 0;
            mtbProfilePhoneNumber.ShortcutsEnabled = true;
            mtbProfilePhoneNumber.Size = new Size(306, 48);
            mtbProfilePhoneNumber.TabIndex = 33;
            mtbProfilePhoneNumber.TabStop = false;
            mtbProfilePhoneNumber.TextAlign = HorizontalAlignment.Left;
            mtbProfilePhoneNumber.TrailingIcon = null;
            mtbProfilePhoneNumber.UseSystemPasswordChar = false;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 10F);
            label34.ForeColor = Color.Gray;
            label34.Location = new Point(31, 360);
            label34.Name = "label34";
            label34.Size = new Size(169, 23);
            label34.TabIndex = 32;
            label34.Text = "Número de Telefone:";
            // 
            // mtbProfileEmail
            // 
            mtbProfileEmail.AnimateReadOnly = false;
            mtbProfileEmail.AutoCompleteMode = AutoCompleteMode.None;
            mtbProfileEmail.AutoCompleteSource = AutoCompleteSource.None;
            mtbProfileEmail.BackgroundImageLayout = ImageLayout.None;
            mtbProfileEmail.CharacterCasing = CharacterCasing.Normal;
            mtbProfileEmail.Depth = 0;
            mtbProfileEmail.Enabled = false;
            mtbProfileEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbProfileEmail.HideSelection = true;
            mtbProfileEmail.LeadingIcon = null;
            mtbProfileEmail.Location = new Point(31, 301);
            mtbProfileEmail.MaxLength = 32767;
            mtbProfileEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbProfileEmail.Name = "mtbProfileEmail";
            mtbProfileEmail.PasswordChar = '\0';
            mtbProfileEmail.PrefixSuffixText = null;
            mtbProfileEmail.ReadOnly = true;
            mtbProfileEmail.RightToLeft = RightToLeft.No;
            mtbProfileEmail.SelectedText = "";
            mtbProfileEmail.SelectionLength = 0;
            mtbProfileEmail.SelectionStart = 0;
            mtbProfileEmail.ShortcutsEnabled = true;
            mtbProfileEmail.Size = new Size(306, 48);
            mtbProfileEmail.TabIndex = 31;
            mtbProfileEmail.TabStop = false;
            mtbProfileEmail.TextAlign = HorizontalAlignment.Left;
            mtbProfileEmail.TrailingIcon = null;
            mtbProfileEmail.UseSystemPasswordChar = false;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10F);
            label33.ForeColor = Color.Gray;
            label33.Location = new Point(31, 275);
            label33.Name = "label33";
            label33.Size = new Size(55, 23);
            label33.TabIndex = 30;
            label33.Text = "Email:";
            // 
            // materialCard4
            // 
            materialCard4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(label10);
            materialCard4.Controls.Add(label30);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(17, 3);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(914, 106);
            materialCard4.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(17, 61);
            label10.Name = "label10";
            label10.Size = new Size(180, 23);
            label10.TabIndex = 25;
            label10.Text = "Informações da conta.";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(17, 14);
            label30.Name = "label30";
            label30.Size = new Size(87, 38);
            label30.TabIndex = 25;
            label30.Text = "Perfil";
            // 
            // mtbProfileName
            // 
            mtbProfileName.AnimateReadOnly = false;
            mtbProfileName.AutoCompleteMode = AutoCompleteMode.None;
            mtbProfileName.AutoCompleteSource = AutoCompleteSource.None;
            mtbProfileName.BackgroundImageLayout = ImageLayout.None;
            mtbProfileName.CharacterCasing = CharacterCasing.Normal;
            mtbProfileName.Depth = 0;
            mtbProfileName.Enabled = false;
            mtbProfileName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbProfileName.HideSelection = true;
            mtbProfileName.LeadingIcon = null;
            mtbProfileName.Location = new Point(31, 218);
            mtbProfileName.MaxLength = 32767;
            mtbProfileName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbProfileName.Name = "mtbProfileName";
            mtbProfileName.PasswordChar = '\0';
            mtbProfileName.PrefixSuffixText = null;
            mtbProfileName.ReadOnly = true;
            mtbProfileName.RightToLeft = RightToLeft.No;
            mtbProfileName.SelectedText = "";
            mtbProfileName.SelectionLength = 0;
            mtbProfileName.SelectionStart = 0;
            mtbProfileName.ShortcutsEnabled = true;
            mtbProfileName.Size = new Size(306, 48);
            mtbProfileName.TabIndex = 29;
            mtbProfileName.TabStop = false;
            mtbProfileName.TextAlign = HorizontalAlignment.Left;
            mtbProfileName.TrailingIcon = null;
            mtbProfileName.UseSystemPasswordChar = false;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10F);
            label32.ForeColor = Color.Gray;
            label32.Location = new Point(31, 192);
            label32.Name = "label32";
            label32.Size = new Size(146, 23);
            label32.TabIndex = 26;
            label32.Text = "Nome de usuário:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(31, 143);
            label31.Name = "label31";
            label31.Size = new Size(217, 31);
            label31.TabIndex = 26;
            label31.Text = "Informações gerais";
            // 
            // tabPageAvailability
            // 
            tabPageAvailability.Controls.Add(cardSaturdayAvailability);
            tabPageAvailability.Controls.Add(materialCard1);
            tabPageAvailability.Location = new Point(4, 29);
            tabPageAvailability.Name = "tabPageAvailability";
            tabPageAvailability.Padding = new Padding(3);
            tabPageAvailability.Size = new Size(948, 725);
            tabPageAvailability.TabIndex = 6;
            tabPageAvailability.Text = "Availability";
            tabPageAvailability.UseVisualStyleBackColor = true;
            // 
            // cardSaturdayAvailability
            // 
            cardSaturdayAvailability.BackColor = Color.FromArgb(255, 255, 255);
            cardSaturdayAvailability.Controls.Add(lblEndTime);
            cardSaturdayAvailability.Controls.Add(label21);
            cardSaturdayAvailability.Controls.Add(lblStartTime);
            cardSaturdayAvailability.Controls.Add(label18);
            cardSaturdayAvailability.Controls.Add(btnEditDayAvailability);
            cardSaturdayAvailability.Controls.Add(label17);
            cardSaturdayAvailability.Depth = 0;
            cardSaturdayAvailability.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cardSaturdayAvailability.Location = new Point(17, 143);
            cardSaturdayAvailability.Margin = new Padding(14);
            cardSaturdayAvailability.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            cardSaturdayAvailability.Name = "cardSaturdayAvailability";
            cardSaturdayAvailability.Padding = new Padding(14);
            cardSaturdayAvailability.Size = new Size(250, 246);
            cardSaturdayAvailability.TabIndex = 29;
            cardSaturdayAvailability.Visible = false;
            // 
            // lblEndTime
            // 
            lblEndTime.Font = new Font("Segoe UI", 10F);
            lblEndTime.ForeColor = Color.Black;
            lblEndTime.Location = new Point(18, 147);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(121, 23);
            lblEndTime.TabIndex = 31;
            lblEndTime.Text = "19:00";
            // 
            // label21
            // 
            label21.Font = new Font("Segoe UI", 10F);
            label21.ForeColor = Color.Gray;
            label21.Location = new Point(18, 124);
            label21.Name = "label21";
            label21.Size = new Size(186, 23);
            label21.TabIndex = 30;
            label21.Text = "Horário Encerramento:";
            // 
            // lblStartTime
            // 
            lblStartTime.Font = new Font("Segoe UI", 10F);
            lblStartTime.ForeColor = Color.Black;
            lblStartTime.Location = new Point(18, 90);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(121, 23);
            lblStartTime.TabIndex = 29;
            lblStartTime.Text = "08:00";
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 10F);
            label18.ForeColor = Color.Gray;
            label18.Location = new Point(18, 67);
            label18.Name = "label18";
            label18.Size = new Size(121, 23);
            label18.TabIndex = 26;
            label18.Text = "Horário Inicio:";
            // 
            // btnEditDayAvailability
            // 
            btnEditDayAvailability.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditDayAvailability.AutoSize = false;
            btnEditDayAvailability.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditDayAvailability.BackColor = SystemColors.Control;
            btnEditDayAvailability.Density = MaterialButton.MaterialButtonDensity.Default;
            btnEditDayAvailability.Depth = 0;
            btnEditDayAvailability.HighEmphasis = true;
            btnEditDayAvailability.Icon = null;
            btnEditDayAvailability.IconType = MaterialButton.MaterialIconType.Rebase;
            btnEditDayAvailability.Location = new Point(18, 190);
            btnEditDayAvailability.Margin = new Padding(4, 6, 4, 6);
            btnEditDayAvailability.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditDayAvailability.Name = "btnEditDayAvailability";
            btnEditDayAvailability.NoAccentTextColor = Color.Empty;
            btnEditDayAvailability.Size = new Size(214, 36);
            btnEditDayAvailability.TabIndex = 27;
            btnEditDayAvailability.Text = "Editar";
            btnEditDayAvailability.Type = MaterialButton.MaterialButtonType.Outlined;
            btnEditDayAvailability.UseAccentColor = false;
            btnEditDayAvailability.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(14, 26);
            label17.Name = "label17";
            label17.Size = new Size(115, 31);
            label17.TabIndex = 28;
            label17.Text = "Domingo";
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(label15);
            materialCard1.Controls.Add(label16);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 0);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(917, 106);
            materialCard1.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.ForeColor = Color.Gray;
            label15.Location = new Point(17, 61);
            label15.Name = "label15";
            label15.Size = new Size(658, 23);
            label15.TabIndex = 25;
            label15.Text = "Gerencie seus horários da semana, defina disponibilidades para cada dia de trabalho.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(17, 14);
            label16.Name = "label16";
            label16.Size = new Size(222, 38);
            label16.TabIndex = 25;
            label16.Text = "Disponibilidade";
            // 
            // materialButton3
            // 
            materialButton3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.BackColor = SystemColors.Control;
            materialButton3.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = Properties.Resources.calendar_plus;
            materialButton3.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton3.Location = new Point(1344, 27);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(193, 55);
            materialButton3.TabIndex = 26;
            materialButton3.Text = "Novo Agendamento";
            materialButton3.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = false;
            // 
            // materialButton4
            // 
            materialButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton4.AutoSize = false;
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.BackColor = SystemColors.Control;
            materialButton4.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = Properties.Resources.barber_pole;
            materialButton4.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton4.Location = new Point(1545, 27);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(153, 55);
            materialButton4.TabIndex = 25;
            materialButton4.Text = "Novo Serviço";
            materialButton4.Type = MaterialButton.MaterialButtonType.Outlined;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = false;
            // 
            // materialButton5
            // 
            materialButton5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton5.AutoSize = false;
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.BackColor = SystemColors.Control;
            materialButton5.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = Properties.Resources.calendar_plus;
            materialButton5.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton5.Location = new Point(2109, 27);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(193, 493);
            materialButton5.TabIndex = 26;
            materialButton5.Text = "Novo Agendamento";
            materialButton5.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = false;
            // 
            // materialButton6
            // 
            materialButton6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialButton6.AutoSize = false;
            materialButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton6.BackColor = SystemColors.Control;
            materialButton6.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton6.Depth = 0;
            materialButton6.HighEmphasis = true;
            materialButton6.Icon = Properties.Resources.barber_pole;
            materialButton6.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton6.Location = new Point(2310, 27);
            materialButton6.Margin = new Padding(4, 6, 4, 6);
            materialButton6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton6.Name = "materialButton6";
            materialButton6.NoAccentTextColor = Color.Empty;
            materialButton6.Size = new Size(153, 493);
            materialButton6.TabIndex = 25;
            materialButton6.Text = "Novo Serviço";
            materialButton6.Type = MaterialButton.MaterialButtonType.Outlined;
            materialButton6.UseAccentColor = false;
            materialButton6.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 831);
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
            flpAppointmentRequest.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            appointmentCard.ResumeLayout(false);
            appointmentCard.PerformLayout();
            tabPageServices.ResumeLayout(false);
            tabPageServices.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            tabPageBarbers.ResumeLayout(false);
            tabPageBarbers.PerformLayout();
            tabPageReports.ResumeLayout(false);
            tabPageReports.PerformLayout();
            tabPageConfigurations.ResumeLayout(false);
            tabPageConfigurations.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            tabPageAvailability.ResumeLayout(false);
            cardSaturdayAvailability.ResumeLayout(false);
            cardSaturdayAvailability.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPageAppointments;
        private System.Windows.Forms.TabPage tabPageServices;
        private System.Windows.Forms.TabPage tabPageBarbers;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.TabPage tabPageConfigurations;
        private Label label6;
        private Label label8;
        private Label label9;
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
        private ReaLTaiizor.Controls.Button btnBarberAvailabilities;
        private System.Windows.Forms.TabPage tabPageAvailability;
        private ReaLTaiizor.Controls.MaterialButton btnNewAppointment;
        private ReaLTaiizor.Controls.MaterialButton mtbRegisterBarberProfile;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private Label label15;
        private Label label16;
        private ReaLTaiizor.Controls.MaterialCard cardSaturdayAvailability;
        private Label label17;
        private Label lblEndTime;
        private Label label21;
        private Label lblStartTime;
        private Label label18;
        private ReaLTaiizor.Controls.MaterialButton btnEditDayAvailability;
        private ReaLTaiizor.Controls.MaterialCard materialCard2;
        private ReaLTaiizor.Controls.MaterialButton mtbNewService;
        private Label label7;
        private Label label19;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbServiceName;
        private ReaLTaiizor.Controls.MaterialButton btnSearchServices;
        private Label label20;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbDurationFilter;
        private Label label23;
        private ReaLTaiizor.Controls.MaterialComboBox mcbPriceOperatorFilter;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbPriceFilter;
        private Label label22;
        private ReaLTaiizor.Controls.MaterialComboBox mcbDurationOperatorFilter;
        private ReaLTaiizor.Controls.MaterialButton btnApplyFilters;
        private FlowLayoutPanel flpServiceCardList;
        private ReaLTaiizor.Controls.MaterialCard materialCard3;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private Label label25;
        private Label label24;
        private ReaLTaiizor.Controls.MaterialCard materialCard4;
        private Label label10;
        private Label label30;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbProfileName;
        private Label label32;
        private Label label31;
        private MaterialTextBoxEdit mtbProfilePhoneNumber;
        private Label label34;
        private MaterialTextBoxEdit mtbProfileEmail;
        private Label label33;
        private MaterialTextBoxEdit mtbProfilePromotionPoints;
        private Label label35;
        private MaterialCheckBox mchbProfileEditMode;
        private MaterialButton btnSaveProfileChanges;
        private Label label38;
        private MaterialTextBoxEdit mtbBarberPortifolioUrl;
        private Label label37;
        private MaterialRichTextBox mrtbBarberDescription;
        private Label label36;
        private MaterialTextBoxEdit mtbBarberCep;
        private Label label39;
        private MaterialTextBoxEdit mtbBarberAddressNumber;
        private Label label40;
        private MaterialTextBoxEdit mtbBarberAddress;
        private Label label44;
        private MaterialTextBoxEdit mtbBarberAddressCity;
        private Label label43;
        private MaterialTextBoxEdit mtbBarberAddressState;
        private Label label42;
        private MaterialTextBoxEdit mtbBarberAddressCountry;
        private Label label41;
        private MaterialButton btnSaveBarberChanges;
        private MaterialCheckBox mchbBarberEditMode;
        private FlowLayoutPanel flpAppointments;
        private Label label45;
        private FlowLayoutPanel flpAppointmentRequest;
        private MaterialCard materialCard5;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private MaterialButton materialButton1;
        private MaterialButton btnConfirmAppointment;
        private System.Windows.Forms.CheckBox checkBox1;
        private MaterialComboBox mcbAppointmentStatus;
        private Label label51;
    }
}