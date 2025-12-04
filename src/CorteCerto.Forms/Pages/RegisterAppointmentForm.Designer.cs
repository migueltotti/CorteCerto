namespace CorteCerto.App.Pages
{
    partial class RegisterAppointmentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            tabControlRegister = new TabControl();
            tabPageService = new TabPage();
            label10 = new Label();
            cbTimeAvailable = new ReaLTaiizor.Controls.PoisonComboBox();
            dataGridViewServices = new ReaLTaiizor.Controls.PoisonDataGridView();
            btnSearchServices = new ReaLTaiizor.Controls.MaterialButton();
            mtbServiceName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label9 = new Label();
            lblDate = new Label();
            lblBarber = new Label();
            lblService = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dpAppointmentDate = new ReaLTaiizor.Controls.HopeDatePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            mtbBarberName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label1 = new Label();
            tabPageBarber = new TabPage();
            dgwServices2 = new ReaLTaiizor.Controls.PoisonDataGridView();
            label22 = new Label();
            label23 = new Label();
            dgwBarbers = new ReaLTaiizor.Controls.PoisonDataGridView();
            mtbBarberSearch2 = new ReaLTaiizor.Controls.MaterialButton();
            mtbBarberName2 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label20 = new Label();
            label21 = new Label();
            label11 = new Label();
            cbAvailabilities = new ReaLTaiizor.Controls.PoisonComboBox();
            label12 = new Label();
            lblDate2 = new Label();
            lblServiceName2 = new Label();
            lblBarberName2 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            dpDate2 = new ReaLTaiizor.Controls.HopeDatePicker();
            actionPanel.SuspendLayout();
            fieldPanel.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            tabPageBarber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwServices2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwBarbers).BeginInit();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Location = new Point(3, 651);
            actionPanel.Size = new Size(897, 64);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(780, 16);
            btnCancel.MaximumSize = new Size(116, 32);
            btnCancel.MinimumSize = new Size(116, 32);
            btnCancel.Size = new Size(116, 32);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.AutoSizeMode = AutoSizeMode.GrowOnly;
            btnSave.Location = new Point(656, 16);
            btnSave.MaximumSize = new Size(116, 32);
            btnSave.MinimumSize = new Size(116, 32);
            btnSave.Size = new Size(116, 32);
            // 
            // fieldPanel
            // 
            fieldPanel.Controls.Add(tabControlRegister);
            fieldPanel.Size = new Size(897, 587);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Controls.Add(tabPageService);
            tabControlRegister.Controls.Add(tabPageBarber);
            tabControlRegister.Dock = DockStyle.Fill;
            tabControlRegister.Location = new Point(0, 0);
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(897, 587);
            tabControlRegister.TabIndex = 0;
            // 
            // tabPageService
            // 
            tabPageService.Controls.Add(label10);
            tabPageService.Controls.Add(cbTimeAvailable);
            tabPageService.Controls.Add(dataGridViewServices);
            tabPageService.Controls.Add(btnSearchServices);
            tabPageService.Controls.Add(mtbServiceName);
            tabPageService.Controls.Add(label9);
            tabPageService.Controls.Add(lblDate);
            tabPageService.Controls.Add(lblBarber);
            tabPageService.Controls.Add(lblService);
            tabPageService.Controls.Add(label8);
            tabPageService.Controls.Add(label7);
            tabPageService.Controls.Add(label6);
            tabPageService.Controls.Add(label5);
            tabPageService.Controls.Add(dpAppointmentDate);
            tabPageService.Controls.Add(label4);
            tabPageService.Controls.Add(label3);
            tabPageService.Controls.Add(label2);
            tabPageService.Controls.Add(mtbBarberName);
            tabPageService.Controls.Add(label1);
            tabPageService.Location = new Point(4, 29);
            tabPageService.Name = "tabPageService";
            tabPageService.Padding = new Padding(3);
            tabPageService.Size = new Size(889, 554);
            tabPageService.TabIndex = 0;
            tabPageService.Text = "Service";
            tabPageService.UseVisualStyleBackColor = true;
            tabPageService.Enter += tabPageService_Enter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(624, 319);
            label10.Name = "label10";
            label10.Size = new Size(160, 18);
            label10.TabIndex = 20;
            label10.Text = "Selecione um horário:";
            // 
            // cbTimeAvailable
            // 
            cbTimeAvailable.Enabled = false;
            cbTimeAvailable.FormattingEnabled = true;
            cbTimeAvailable.ItemHeight = 24;
            cbTimeAvailable.Location = new Point(623, 340);
            cbTimeAvailable.Name = "cbTimeAvailable";
            cbTimeAvailable.Size = new Size(250, 30);
            cbTimeAvailable.TabIndex = 19;
            cbTimeAvailable.UseSelectable = true;
            cbTimeAvailable.SelectedIndexChanged += cbTimeAvailable_SelectedIndexChanged;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.AllowUserToResizeRows = false;
            dataGridViewServices.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridViewServices.BorderStyle = BorderStyle.None;
            dataGridViewServices.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewServices.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewServices.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewServices.EnableHeadersVisualStyles = false;
            dataGridViewServices.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewServices.GridColor = Color.FromArgb(255, 255, 255);
            dataGridViewServices.Location = new Point(19, 118);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.ReadOnly = true;
            dataGridViewServices.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewServices.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewServices.Size = new Size(556, 285);
            dataGridViewServices.TabIndex = 18;
            dataGridViewServices.DoubleClick += dataGridViewServices_DoubleClick;
            // 
            // btnSearchServices
            // 
            btnSearchServices.AutoSize = false;
            btnSearchServices.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearchServices.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearchServices.Depth = 0;
            btnSearchServices.ForeColor = Color.Black;
            btnSearchServices.HighEmphasis = true;
            btnSearchServices.Icon = Properties.Resources.search;
            btnSearchServices.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            btnSearchServices.Location = new Point(529, 69);
            btnSearchServices.Margin = new Padding(4, 6, 4, 6);
            btnSearchServices.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSearchServices.Name = "btnSearchServices";
            btnSearchServices.NoAccentTextColor = Color.Empty;
            btnSearchServices.Size = new Size(46, 40);
            btnSearchServices.TabIndex = 17;
            btnSearchServices.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearchServices.UseAccentColor = false;
            btnSearchServices.UseVisualStyleBackColor = true;
            btnSearchServices.Click += btnSearchServices_Click;
            // 
            // mtbServiceName
            // 
            mtbServiceName.AnimateReadOnly = false;
            mtbServiceName.AutoCompleteMode = AutoCompleteMode.None;
            mtbServiceName.AutoCompleteSource = AutoCompleteSource.None;
            mtbServiceName.BackgroundImageLayout = ImageLayout.None;
            mtbServiceName.CharacterCasing = CharacterCasing.Normal;
            mtbServiceName.Depth = 0;
            mtbServiceName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbServiceName.HideSelection = true;
            mtbServiceName.LeadingIcon = null;
            mtbServiceName.Location = new Point(19, 64);
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
            mtbServiceName.Size = new Size(503, 48);
            mtbServiceName.TabIndex = 16;
            mtbServiceName.TabStop = false;
            mtbServiceName.TextAlign = HorizontalAlignment.Left;
            mtbServiceName.TrailingIcon = null;
            mtbServiceName.UseSystemPasswordChar = false;
            mtbServiceName.KeyDown += mtbServiceName_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(638, 8);
            label9.Name = "label9";
            label9.Size = new Size(223, 28);
            label9.TabIndex = 15;
            label9.Text = "Data do agendamento";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 9F);
            lblDate.Location = new Point(638, 526);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(235, 25);
            lblDate.TabIndex = 14;
            // 
            // lblBarber
            // 
            lblBarber.Font = new Font("Segoe UI", 9F);
            lblBarber.Location = new Point(652, 467);
            lblBarber.Name = "lblBarber";
            lblBarber.Size = new Size(216, 54);
            lblBarber.TabIndex = 13;
            // 
            // lblService
            // 
            lblService.Font = new Font("Segoe UI", 9F);
            lblService.Location = new Point(656, 413);
            lblService.Name = "lblService";
            lblService.Size = new Size(217, 54);
            lblService.TabIndex = 12;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(586, 526);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 11;
            label8.Text = "Data:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(586, 467);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 10;
            label7.Text = "Barbeiro:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(586, 413);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 9;
            label6.Text = "Serviço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(586, 376);
            label5.Name = "label5";
            label5.Size = new Size(258, 28);
            label5.TabIndex = 8;
            label5.Text = "Resumo do agendamento:";
            // 
            // dpAppointmentDate
            // 
            dpAppointmentDate.BackColor = Color.White;
            dpAppointmentDate.BorderColor = Color.FromArgb(220, 223, 230);
            dpAppointmentDate.Date = new DateTime(2025, 12, 2, 0, 0, 0, 0);
            dpAppointmentDate.DayNames = "MTWTFSS";
            dpAppointmentDate.DaysTextColor = Color.FromArgb(96, 98, 102);
            dpAppointmentDate.DayTextColorA = Color.FromArgb(48, 49, 51);
            dpAppointmentDate.DayTextColorB = Color.FromArgb(144, 147, 153);
            dpAppointmentDate.HeaderFormat = "{0} Y - {1} M";
            dpAppointmentDate.HeaderTextColor = Color.FromArgb(48, 49, 51);
            dpAppointmentDate.HeadLineColor = Color.FromArgb(228, 231, 237);
            dpAppointmentDate.HoverColor = Color.FromArgb(235, 238, 245);
            dpAppointmentDate.Location = new Point(624, 46);
            dpAppointmentDate.Name = "dpAppointmentDate";
            dpAppointmentDate.NMColor = Color.FromArgb(192, 196, 204);
            dpAppointmentDate.NMHoverColor = Color.FromArgb(64, 158, 255);
            dpAppointmentDate.NYColor = Color.FromArgb(192, 196, 204);
            dpAppointmentDate.NYHoverColor = Color.FromArgb(64, 158, 255);
            dpAppointmentDate.PMColor = Color.FromArgb(192, 196, 204);
            dpAppointmentDate.PMHoverColor = Color.FromArgb(64, 158, 255);
            dpAppointmentDate.PYColor = Color.FromArgb(192, 196, 204);
            dpAppointmentDate.PYHoverColor = Color.FromArgb(64, 158, 255);
            dpAppointmentDate.SelectedBackColor = Color.FromArgb(64, 158, 255);
            dpAppointmentDate.SelectedTextColor = Color.White;
            dpAppointmentDate.Size = new Size(250, 270);
            dpAppointmentDate.TabIndex = 7;
            dpAppointmentDate.Text = "hopeDatePicker1";
            dpAppointmentDate.ValueTextColor = Color.FromArgb(43, 133, 228);
            dpAppointmentDate.onDateChanged += dpAppointmentDate_onDateChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(19, 435);
            label4.Name = "label4";
            label4.Size = new Size(184, 25);
            label4.TabIndex = 5;
            label4.Text = "Responsavel pelo serviço.\r\n";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(19, 36);
            label3.Name = "label3";
            label3.Size = new Size(524, 25);
            label3.TabIndex = 4;
            label3.Text = "Digite o nome do seriviço e escolha o que mais se adequa a sua necessidade.\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(19, 406);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Barbeiro";
            // 
            // mtbBarberName
            // 
            mtbBarberName.AnimateReadOnly = false;
            mtbBarberName.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberName.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberName.BackgroundImageLayout = ImageLayout.None;
            mtbBarberName.CharacterCasing = CharacterCasing.Normal;
            mtbBarberName.Depth = 0;
            mtbBarberName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberName.HideSelection = true;
            mtbBarberName.LeadingIcon = null;
            mtbBarberName.Location = new Point(19, 463);
            mtbBarberName.MaxLength = 32767;
            mtbBarberName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberName.Name = "mtbBarberName";
            mtbBarberName.PasswordChar = '\0';
            mtbBarberName.PrefixSuffixText = null;
            mtbBarberName.ReadOnly = true;
            mtbBarberName.RightToLeft = RightToLeft.No;
            mtbBarberName.SelectedText = "";
            mtbBarberName.SelectionLength = 0;
            mtbBarberName.SelectionStart = 0;
            mtbBarberName.ShortcutsEnabled = true;
            mtbBarberName.Size = new Size(556, 48);
            mtbBarberName.TabIndex = 2;
            mtbBarberName.TabStop = false;
            mtbBarberName.TextAlign = HorizontalAlignment.Left;
            mtbBarberName.TrailingIcon = null;
            mtbBarberName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(19, 8);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 1;
            label1.Text = "Serviço";
            // 
            // tabPageBarber
            // 
            tabPageBarber.Controls.Add(dgwServices2);
            tabPageBarber.Controls.Add(label22);
            tabPageBarber.Controls.Add(label23);
            tabPageBarber.Controls.Add(dgwBarbers);
            tabPageBarber.Controls.Add(mtbBarberSearch2);
            tabPageBarber.Controls.Add(mtbBarberName2);
            tabPageBarber.Controls.Add(label20);
            tabPageBarber.Controls.Add(label21);
            tabPageBarber.Controls.Add(label11);
            tabPageBarber.Controls.Add(cbAvailabilities);
            tabPageBarber.Controls.Add(label12);
            tabPageBarber.Controls.Add(lblDate2);
            tabPageBarber.Controls.Add(lblServiceName2);
            tabPageBarber.Controls.Add(lblBarberName2);
            tabPageBarber.Controls.Add(label16);
            tabPageBarber.Controls.Add(label17);
            tabPageBarber.Controls.Add(label18);
            tabPageBarber.Controls.Add(label19);
            tabPageBarber.Controls.Add(dpDate2);
            tabPageBarber.Location = new Point(4, 29);
            tabPageBarber.Name = "tabPageBarber";
            tabPageBarber.Padding = new Padding(3);
            tabPageBarber.Size = new Size(889, 554);
            tabPageBarber.TabIndex = 1;
            tabPageBarber.Text = "Barber";
            tabPageBarber.UseVisualStyleBackColor = true;
            tabPageBarber.Enter += tabPageBarber_Enter;
            // 
            // dgwServices2
            // 
            dgwServices2.AllowUserToResizeRows = false;
            dgwServices2.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgwServices2.BorderStyle = BorderStyle.None;
            dgwServices2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwServices2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgwServices2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgwServices2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgwServices2.DefaultCellStyle = dataGridViewCellStyle5;
            dgwServices2.EnableHeadersVisualStyles = false;
            dgwServices2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgwServices2.GridColor = Color.FromArgb(255, 255, 255);
            dgwServices2.Location = new Point(18, 368);
            dgwServices2.Name = "dgwServices2";
            dgwServices2.ReadOnly = true;
            dgwServices2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgwServices2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgwServices2.RowHeadersWidth = 51;
            dgwServices2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwServices2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwServices2.Size = new Size(556, 183);
            dgwServices2.TabIndex = 41;
            dgwServices2.DoubleClick += dgwServices2_DoubleClick;
            // 
            // label22
            // 
            label22.Font = new Font("Segoe UI", 9F);
            label22.Location = new Point(18, 338);
            label22.Name = "label22";
            label22.Size = new Size(524, 25);
            label22.TabIndex = 38;
            label22.Text = "Escolha um dos serviços disponiveis para o barbeiro escolhido.";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label23.Location = new Point(18, 310);
            label23.Name = "label23";
            label23.Size = new Size(82, 28);
            label23.TabIndex = 37;
            label23.Text = "Serviço";
            // 
            // dgwBarbers
            // 
            dgwBarbers.AllowUserToResizeRows = false;
            dgwBarbers.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgwBarbers.BorderStyle = BorderStyle.None;
            dgwBarbers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwBarbers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgwBarbers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgwBarbers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgwBarbers.DefaultCellStyle = dataGridViewCellStyle8;
            dgwBarbers.EnableHeadersVisualStyles = false;
            dgwBarbers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgwBarbers.GridColor = Color.FromArgb(255, 255, 255);
            dgwBarbers.Location = new Point(18, 117);
            dgwBarbers.Name = "dgwBarbers";
            dgwBarbers.ReadOnly = true;
            dgwBarbers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgwBarbers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgwBarbers.RowHeadersWidth = 51;
            dgwBarbers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgwBarbers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwBarbers.Size = new Size(556, 190);
            dgwBarbers.TabIndex = 36;
            dgwBarbers.DoubleClick += dgwBarbers_DoubleClick;
            // 
            // mtbBarberSearch2
            // 
            mtbBarberSearch2.AutoSize = false;
            mtbBarberSearch2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtbBarberSearch2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mtbBarberSearch2.Depth = 0;
            mtbBarberSearch2.ForeColor = Color.Black;
            mtbBarberSearch2.HighEmphasis = true;
            mtbBarberSearch2.Icon = Properties.Resources.search;
            mtbBarberSearch2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Default;
            mtbBarberSearch2.Location = new Point(528, 68);
            mtbBarberSearch2.Margin = new Padding(4, 6, 4, 6);
            mtbBarberSearch2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtbBarberSearch2.Name = "mtbBarberSearch2";
            mtbBarberSearch2.NoAccentTextColor = Color.Empty;
            mtbBarberSearch2.Size = new Size(46, 40);
            mtbBarberSearch2.TabIndex = 35;
            mtbBarberSearch2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mtbBarberSearch2.UseAccentColor = false;
            mtbBarberSearch2.UseVisualStyleBackColor = true;
            mtbBarberSearch2.Click += mtbBarberSearch2_Click;
            // 
            // mtbBarberName2
            // 
            mtbBarberName2.AnimateReadOnly = false;
            mtbBarberName2.AutoCompleteMode = AutoCompleteMode.None;
            mtbBarberName2.AutoCompleteSource = AutoCompleteSource.None;
            mtbBarberName2.BackgroundImageLayout = ImageLayout.None;
            mtbBarberName2.CharacterCasing = CharacterCasing.Normal;
            mtbBarberName2.Depth = 0;
            mtbBarberName2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberName2.HideSelection = true;
            mtbBarberName2.LeadingIcon = null;
            mtbBarberName2.Location = new Point(18, 63);
            mtbBarberName2.MaxLength = 32767;
            mtbBarberName2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberName2.Name = "mtbBarberName2";
            mtbBarberName2.PasswordChar = '\0';
            mtbBarberName2.PrefixSuffixText = null;
            mtbBarberName2.ReadOnly = false;
            mtbBarberName2.RightToLeft = RightToLeft.No;
            mtbBarberName2.SelectedText = "";
            mtbBarberName2.SelectionLength = 0;
            mtbBarberName2.SelectionStart = 0;
            mtbBarberName2.ShortcutsEnabled = true;
            mtbBarberName2.Size = new Size(503, 48);
            mtbBarberName2.TabIndex = 34;
            mtbBarberName2.TabStop = false;
            mtbBarberName2.TextAlign = HorizontalAlignment.Left;
            mtbBarberName2.TrailingIcon = null;
            mtbBarberName2.UseSystemPasswordChar = false;
            mtbBarberName2.KeyDown += mtbBarberName2_KeyDown;
            // 
            // label20
            // 
            label20.Font = new Font("Segoe UI", 9F);
            label20.Location = new Point(18, 35);
            label20.Name = "label20";
            label20.Size = new Size(524, 25);
            label20.TabIndex = 33;
            label20.Text = "Digite o nome do seriviço e escolha o que mais se adequa a sua necessidade.\r\n\r\n";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.Location = new Point(18, 7);
            label21.Name = "label21";
            label21.Size = new Size(93, 28);
            label21.TabIndex = 32;
            label21.Text = "Barbeiro";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(624, 317);
            label11.Name = "label11";
            label11.Size = new Size(160, 18);
            label11.TabIndex = 31;
            label11.Text = "Selecione um horário:";
            // 
            // cbAvailabilities
            // 
            cbAvailabilities.Enabled = false;
            cbAvailabilities.FormattingEnabled = true;
            cbAvailabilities.ItemHeight = 24;
            cbAvailabilities.Location = new Point(623, 338);
            cbAvailabilities.Name = "cbAvailabilities";
            cbAvailabilities.Size = new Size(250, 30);
            cbAvailabilities.TabIndex = 30;
            cbAvailabilities.UseSelectable = true;
            cbAvailabilities.SelectedIndexChanged += cbAvailabilities_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(638, 6);
            label12.Name = "label12";
            label12.Size = new Size(223, 28);
            label12.TabIndex = 29;
            label12.Text = "Data do agendamento";
            // 
            // lblDate2
            // 
            lblDate2.Font = new Font("Segoe UI", 9F);
            lblDate2.Location = new Point(638, 524);
            lblDate2.Name = "lblDate2";
            lblDate2.Size = new Size(235, 25);
            lblDate2.TabIndex = 28;
            // 
            // lblServiceName2
            // 
            lblServiceName2.Font = new Font("Segoe UI", 9F);
            lblServiceName2.Location = new Point(652, 465);
            lblServiceName2.Name = "lblServiceName2";
            lblServiceName2.Size = new Size(216, 54);
            lblServiceName2.TabIndex = 27;
            // 
            // lblBarberName2
            // 
            lblBarberName2.Font = new Font("Segoe UI", 9F);
            lblBarberName2.Location = new Point(665, 411);
            lblBarberName2.Name = "lblBarberName2";
            lblBarberName2.Size = new Size(208, 54);
            lblBarberName2.TabIndex = 26;
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.Location = new Point(586, 524);
            label16.Name = "label16";
            label16.Size = new Size(65, 25);
            label16.TabIndex = 25;
            label16.Text = "Data:";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.Location = new Point(586, 465);
            label17.Name = "label17";
            label17.Size = new Size(73, 25);
            label17.TabIndex = 24;
            label17.Text = "Serviço:";
            // 
            // label18
            // 
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(586, 411);
            label18.Name = "label18";
            label18.Size = new Size(73, 25);
            label18.TabIndex = 23;
            label18.Text = "Barbeiro:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.Location = new Point(586, 374);
            label19.Name = "label19";
            label19.Size = new Size(258, 28);
            label19.TabIndex = 22;
            label19.Text = "Resumo do agendamento:";
            // 
            // dpDate2
            // 
            dpDate2.BackColor = Color.White;
            dpDate2.BorderColor = Color.FromArgb(220, 223, 230);
            dpDate2.Date = new DateTime(2025, 12, 2, 0, 0, 0, 0);
            dpDate2.DayNames = "MTWTFSS";
            dpDate2.DaysTextColor = Color.FromArgb(96, 98, 102);
            dpDate2.DayTextColorA = Color.FromArgb(48, 49, 51);
            dpDate2.DayTextColorB = Color.FromArgb(144, 147, 153);
            dpDate2.HeaderFormat = "{0} Y - {1} M";
            dpDate2.HeaderTextColor = Color.FromArgb(48, 49, 51);
            dpDate2.HeadLineColor = Color.FromArgb(228, 231, 237);
            dpDate2.HoverColor = Color.FromArgb(235, 238, 245);
            dpDate2.Location = new Point(624, 44);
            dpDate2.Name = "dpDate2";
            dpDate2.NMColor = Color.FromArgb(192, 196, 204);
            dpDate2.NMHoverColor = Color.FromArgb(64, 158, 255);
            dpDate2.NYColor = Color.FromArgb(192, 196, 204);
            dpDate2.NYHoverColor = Color.FromArgb(64, 158, 255);
            dpDate2.PMColor = Color.FromArgb(192, 196, 204);
            dpDate2.PMHoverColor = Color.FromArgb(64, 158, 255);
            dpDate2.PYColor = Color.FromArgb(192, 196, 204);
            dpDate2.PYHoverColor = Color.FromArgb(64, 158, 255);
            dpDate2.SelectedBackColor = Color.FromArgb(64, 158, 255);
            dpDate2.SelectedTextColor = Color.White;
            dpDate2.Size = new Size(250, 270);
            dpDate2.TabIndex = 21;
            dpDate2.Text = "hopeDatePicker1";
            dpDate2.ValueTextColor = Color.FromArgb(43, 133, 228);
            dpDate2.onDateChanged += dpDate2_onDateChanged;
            // 
            // RegisterAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 718);
            MaximizeBox = false;
            MaximumSize = new Size(903, 718);
            MinimizeBox = false;
            MinimumSize = new Size(903, 718);
            Name = "RegisterAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Agendamento";
            Load += RegisterAppointmentForm_Load;
            actionPanel.ResumeLayout(false);
            fieldPanel.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            tabPageService.ResumeLayout(false);
            tabPageService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            tabPageBarber.ResumeLayout(false);
            tabPageBarber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwServices2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwBarbers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRegister;
        private TabPage tabPageService;
        private TabPage tabPageBarber;
        private Label label3;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbBarberName;
        private Label label1;
        private Label label4;
        private ReaLTaiizor.Controls.HopeDatePicker dpAppointmentDate;
        private Label label5;
        private Label lblBarber;
        private Label lblService;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblDate;
        private Label label9;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbServiceName;
        private ReaLTaiizor.Controls.MaterialButton btnSearchServices;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridViewServices;
        private ReaLTaiizor.Controls.PoisonComboBox cbTimeAvailable;
        private Label label10;
        private Label label11;
        private ReaLTaiizor.Controls.PoisonComboBox cbAvailabilities;
        private Label label12;
        private Label lblDate2;
        private Label lblServiceName2;
        private Label lblBarberName2;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private ReaLTaiizor.Controls.HopeDatePicker dpDate2;
        private ReaLTaiizor.Controls.PoisonDataGridView dgwServices2;
        private Label label22;
        private Label label23;
        private ReaLTaiizor.Controls.PoisonDataGridView dgwBarbers;
        private ReaLTaiizor.Controls.MaterialButton mtbBarberSearch2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbBarberName2;
        private Label label20;
        private Label label21;
    }
}