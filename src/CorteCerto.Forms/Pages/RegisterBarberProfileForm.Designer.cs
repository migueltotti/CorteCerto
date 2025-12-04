namespace CorteCerto.App.Pages
{
    partial class RegisterBarberProfileForm
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
            mtbDescription = new ReaLTaiizor.Controls.MaterialRichTextBox();
            label1 = new Label();
            mtbPortifolioUrl = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label2 = new Label();
            label3 = new Label();
            mtbCep = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            label4 = new Label();
            mtbAddressNumber = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblDescriptionError = new Label();
            lblCepError = new Label();
            lblAddressNumberError = new Label();
            actionPanel.SuspendLayout();
            fieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Location = new Point(3, 488);
            actionPanel.Size = new Size(518, 64);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(81, 18);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(-57, 18);
            // 
            // fieldPanel
            // 
            fieldPanel.Controls.Add(lblAddressNumberError);
            fieldPanel.Controls.Add(lblCepError);
            fieldPanel.Controls.Add(lblDescriptionError);
            fieldPanel.Controls.Add(label4);
            fieldPanel.Controls.Add(mtbAddressNumber);
            fieldPanel.Controls.Add(label3);
            fieldPanel.Controls.Add(mtbCep);
            fieldPanel.Controls.Add(label2);
            fieldPanel.Controls.Add(mtbPortifolioUrl);
            fieldPanel.Controls.Add(label1);
            fieldPanel.Controls.Add(mtbDescription);
            fieldPanel.Size = new Size(518, 424);
            // 
            // mtbDescription
            // 
            mtbDescription.BackColor = Color.FromArgb(255, 255, 255);
            mtbDescription.BorderStyle = BorderStyle.None;
            mtbDescription.Depth = 0;
            mtbDescription.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbDescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mtbDescription.Hint = "";
            mtbDescription.Location = new Point(19, 32);
            mtbDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtbDescription.Name = "mtbDescription";
            mtbDescription.Size = new Size(473, 179);
            mtbDescription.TabIndex = 1;
            mtbDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 4);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 2;
            label1.Text = "Descrição do perfil:";
            // 
            // mtbPortifolioUrl
            // 
            mtbPortifolioUrl.AnimateReadOnly = false;
            mtbPortifolioUrl.AutoCompleteMode = AutoCompleteMode.None;
            mtbPortifolioUrl.AutoCompleteSource = AutoCompleteSource.None;
            mtbPortifolioUrl.BackgroundImageLayout = ImageLayout.None;
            mtbPortifolioUrl.CharacterCasing = CharacterCasing.Normal;
            mtbPortifolioUrl.Depth = 0;
            mtbPortifolioUrl.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbPortifolioUrl.HideSelection = true;
            mtbPortifolioUrl.Hint = "Url do portifólio";
            mtbPortifolioUrl.LeadingIcon = null;
            mtbPortifolioUrl.Location = new Point(17, 259);
            mtbPortifolioUrl.MaxLength = 32767;
            mtbPortifolioUrl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbPortifolioUrl.Name = "mtbPortifolioUrl";
            mtbPortifolioUrl.PasswordChar = '\0';
            mtbPortifolioUrl.PrefixSuffixText = null;
            mtbPortifolioUrl.ReadOnly = false;
            mtbPortifolioUrl.RightToLeft = RightToLeft.No;
            mtbPortifolioUrl.SelectedText = "";
            mtbPortifolioUrl.SelectionLength = 0;
            mtbPortifolioUrl.SelectionStart = 0;
            mtbPortifolioUrl.ShortcutsEnabled = true;
            mtbPortifolioUrl.Size = new Size(475, 48);
            mtbPortifolioUrl.TabIndex = 3;
            mtbPortifolioUrl.TabStop = false;
            mtbPortifolioUrl.TextAlign = HorizontalAlignment.Left;
            mtbPortifolioUrl.TrailingIcon = null;
            mtbPortifolioUrl.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 231);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "Portifólio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 314);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 6;
            label3.Text = "CEP:";
            // 
            // mtbCep
            // 
            mtbCep.AnimateReadOnly = false;
            mtbCep.AutoCompleteMode = AutoCompleteMode.None;
            mtbCep.AutoCompleteSource = AutoCompleteSource.None;
            mtbCep.BackgroundImageLayout = ImageLayout.None;
            mtbCep.CharacterCasing = CharacterCasing.Normal;
            mtbCep.Depth = 0;
            mtbCep.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbCep.HideSelection = true;
            mtbCep.Hint = "Insira seu cep";
            mtbCep.LeadingIcon = null;
            mtbCep.Location = new Point(17, 342);
            mtbCep.MaxLength = 32767;
            mtbCep.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbCep.Name = "mtbCep";
            mtbCep.PasswordChar = '\0';
            mtbCep.PrefixSuffixText = null;
            mtbCep.ReadOnly = false;
            mtbCep.RightToLeft = RightToLeft.No;
            mtbCep.SelectedText = "";
            mtbCep.SelectionLength = 0;
            mtbCep.SelectionStart = 0;
            mtbCep.ShortcutsEnabled = true;
            mtbCep.Size = new Size(223, 48);
            mtbCep.TabIndex = 5;
            mtbCep.TabStop = false;
            mtbCep.TextAlign = HorizontalAlignment.Left;
            mtbCep.TrailingIcon = null;
            mtbCep.UseSystemPasswordChar = false;
            mtbCep.Leave += mtbCep_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(266, 314);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 8;
            label4.Text = "Numero:";
            // 
            // mtbAddressNumber
            // 
            mtbAddressNumber.AnimateReadOnly = false;
            mtbAddressNumber.AutoCompleteMode = AutoCompleteMode.None;
            mtbAddressNumber.AutoCompleteSource = AutoCompleteSource.None;
            mtbAddressNumber.BackgroundImageLayout = ImageLayout.None;
            mtbAddressNumber.CharacterCasing = CharacterCasing.Normal;
            mtbAddressNumber.Depth = 0;
            mtbAddressNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbAddressNumber.HideSelection = true;
            mtbAddressNumber.Hint = "Insira o numero do endereço";
            mtbAddressNumber.LeadingIcon = null;
            mtbAddressNumber.Location = new Point(264, 342);
            mtbAddressNumber.MaxLength = 32767;
            mtbAddressNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbAddressNumber.Name = "mtbAddressNumber";
            mtbAddressNumber.PasswordChar = '\0';
            mtbAddressNumber.PrefixSuffixText = null;
            mtbAddressNumber.ReadOnly = false;
            mtbAddressNumber.RightToLeft = RightToLeft.No;
            mtbAddressNumber.SelectedText = "";
            mtbAddressNumber.SelectionLength = 0;
            mtbAddressNumber.SelectionStart = 0;
            mtbAddressNumber.ShortcutsEnabled = true;
            mtbAddressNumber.Size = new Size(228, 48);
            mtbAddressNumber.TabIndex = 7;
            mtbAddressNumber.TabStop = false;
            mtbAddressNumber.TextAlign = HorizontalAlignment.Left;
            mtbAddressNumber.TrailingIcon = null;
            mtbAddressNumber.UseSystemPasswordChar = false;
            // 
            // lblDescriptionError
            // 
            lblDescriptionError.AutoSize = true;
            lblDescriptionError.ForeColor = Color.Red;
            lblDescriptionError.Location = new Point(19, 214);
            lblDescriptionError.Name = "lblDescriptionError";
            lblDescriptionError.Size = new Size(50, 20);
            lblDescriptionError.TabIndex = 9;
            lblDescriptionError.Text = "label5";
            lblDescriptionError.Visible = false;
            // 
            // lblCepError
            // 
            lblCepError.AutoSize = true;
            lblCepError.ForeColor = Color.Red;
            lblCepError.Location = new Point(19, 392);
            lblCepError.Name = "lblCepError";
            lblCepError.Size = new Size(50, 20);
            lblCepError.TabIndex = 11;
            lblCepError.Text = "label5";
            lblCepError.Visible = false;
            // 
            // lblAddressNumberError
            // 
            lblAddressNumberError.AutoSize = true;
            lblAddressNumberError.ForeColor = Color.Red;
            lblAddressNumberError.Location = new Point(266, 393);
            lblAddressNumberError.Name = "lblAddressNumberError";
            lblAddressNumberError.Size = new Size(50, 20);
            lblAddressNumberError.TabIndex = 12;
            lblAddressNumberError.Text = "label5";
            lblAddressNumberError.Visible = false;
            // 
            // RegisterBarberProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 555);
            MaximizeBox = false;
            MaximumSize = new Size(524, 555);
            MinimizeBox = false;
            MinimumSize = new Size(524, 555);
            Name = "RegisterBarberProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterBarberProfileForm";
            actionPanel.ResumeLayout(false);
            fieldPanel.ResumeLayout(false);
            fieldPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialRichTextBox mtbDescription;
        private Label label4;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbAddressNumber;
        private Label label3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbCep;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbPortifolioUrl;
        private Label label1;
        private Label lblDescriptionError;
        private Label lblAddressNumberError;
        private Label lblCepError;
    }
}