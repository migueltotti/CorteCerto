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
            tabControlRegister = new TabControl();
            tabPageService = new TabPage();
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
            actionPanel.SuspendLayout();
            fieldPanel.SuspendLayout();
            tabControlRegister.SuspendLayout();
            tabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Location = new Point(3, 651);
            actionPanel.Size = new Size(897, 64);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(656, 16);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(708, 16);
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
            dataGridViewServices.Size = new Size(547, 285);
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
            btnSearchServices.Location = new Point(550, 67);
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
            mtbServiceName.Enabled = false;
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
            mtbServiceName.Size = new Size(524, 48);
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
            lblDate.Location = new Point(638, 486);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(235, 25);
            lblDate.TabIndex = 14;
            lblDate.Text = "b";
            // 
            // lblBarber
            // 
            lblBarber.Font = new Font("Segoe UI", 9F);
            lblBarber.Location = new Point(657, 427);
            lblBarber.Name = "lblBarber";
            lblBarber.Size = new Size(216, 54);
            lblBarber.TabIndex = 13;
            lblBarber.Text = "b";
            // 
            // lblService
            // 
            lblService.Font = new Font("Segoe UI", 9F);
            lblService.Location = new Point(656, 373);
            lblService.Name = "lblService";
            lblService.Size = new Size(217, 54);
            lblService.TabIndex = 12;
            lblService.Text = "b";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(586, 486);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 11;
            label8.Text = "Data:";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(586, 427);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 10;
            label7.Text = "Barbeiro:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(586, 373);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 9;
            label6.Text = "Serviço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(586, 336);
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
            mtbBarberName.Enabled = false;
            mtbBarberName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbBarberName.HideSelection = true;
            mtbBarberName.LeadingIcon = null;
            mtbBarberName.Location = new Point(19, 463);
            mtbBarberName.MaxLength = 32767;
            mtbBarberName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbBarberName.Name = "mtbBarberName";
            mtbBarberName.PasswordChar = '\0';
            mtbBarberName.PrefixSuffixText = null;
            mtbBarberName.ReadOnly = false;
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
            tabPageBarber.Location = new Point(4, 29);
            tabPageBarber.Name = "tabPageBarber";
            tabPageBarber.Padding = new Padding(3);
            tabPageBarber.Size = new Size(889, 554);
            tabPageBarber.TabIndex = 1;
            tabPageBarber.Text = "Barber";
            tabPageBarber.UseVisualStyleBackColor = true;
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
            Click += RegisterAppointmentForm_Click;
            actionPanel.ResumeLayout(false);
            fieldPanel.ResumeLayout(false);
            tabControlRegister.ResumeLayout(false);
            tabPageService.ResumeLayout(false);
            tabPageService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
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
    }
}