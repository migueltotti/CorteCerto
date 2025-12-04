namespace CorteCerto.App.Pages
{
    partial class CreateAccountForm
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
            panel1 = new Panel();
            lblEmailError = new Label();
            lblSpecialCharacterValidation = new Label();
            lblNumberValidation = new Label();
            lblCaseValidation = new Label();
            lblPhoneError = new Label();
            mtbPhoneNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mtbName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mtbLoginPage = new ReaLTaiizor.Controls.MaterialButton();
            btnShowPassword = new ReaLTaiizor.Controls.MaterialButton();
            lblLengthValidation = new Label();
            lblNameError = new Label();
            btnRegister = new ReaLTaiizor.Controls.MaterialButton();
            mtbPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            mtbEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(251, 250, 249);
            panel1.Controls.Add(lblEmailError);
            panel1.Controls.Add(lblSpecialCharacterValidation);
            panel1.Controls.Add(lblNumberValidation);
            panel1.Controls.Add(lblCaseValidation);
            panel1.Controls.Add(lblPhoneError);
            panel1.Controls.Add(mtbPhoneNumber);
            panel1.Controls.Add(mtbName);
            panel1.Controls.Add(mtbLoginPage);
            panel1.Controls.Add(btnShowPassword);
            panel1.Controls.Add(lblLengthValidation);
            panel1.Controls.Add(lblNameError);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(mtbPassword);
            panel1.Controls.Add(mtbEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(289, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 685);
            panel1.TabIndex = 1;
            // 
            // lblEmailError
            // 
            lblEmailError.AutoSize = true;
            lblEmailError.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(39, 319);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(110, 20);
            lblEmailError.TabIndex = 15;
            lblEmailError.Text = "Email incorreto";
            lblEmailError.TextAlign = ContentAlignment.TopCenter;
            lblEmailError.Visible = false;
            // 
            // lblSpecialCharacterValidation
            // 
            lblSpecialCharacterValidation.AutoSize = true;
            lblSpecialCharacterValidation.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecialCharacterValidation.ForeColor = Color.Red;
            lblSpecialCharacterValidation.Location = new Point(39, 575);
            lblSpecialCharacterValidation.Name = "lblSpecialCharacterValidation";
            lblSpecialCharacterValidation.Size = new Size(331, 20);
            lblSpecialCharacterValidation.TabIndex = 14;
            lblSpecialCharacterValidation.Text = "● Deve conter pelo menos um caracter especial.";
            lblSpecialCharacterValidation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumberValidation
            // 
            lblNumberValidation.AutoSize = true;
            lblNumberValidation.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberValidation.ForeColor = Color.Red;
            lblNumberValidation.Location = new Point(39, 555);
            lblNumberValidation.Name = "lblNumberValidation";
            lblNumberValidation.Size = new Size(271, 20);
            lblNumberValidation.TabIndex = 13;
            lblNumberValidation.Text = "● Deve conter pelo menos um numero.";
            lblNumberValidation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCaseValidation
            // 
            lblCaseValidation.AutoSize = true;
            lblCaseValidation.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaseValidation.ForeColor = Color.Red;
            lblCaseValidation.Location = new Point(39, 515);
            lblCaseValidation.Name = "lblCaseValidation";
            lblCaseValidation.Size = new Size(341, 40);
            lblCaseValidation.TabIndex = 12;
            lblCaseValidation.Text = "● Deve conter pelo menos uma letra maiuscula e \r\numa letra minuscula.";
            lblCaseValidation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhoneError
            // 
            lblPhoneError.AutoSize = true;
            lblPhoneError.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(37, 404);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(119, 20);
            lblPhoneError.TabIndex = 11;
            lblPhoneError.Text = "Celular incorreto";
            lblPhoneError.TextAlign = ContentAlignment.TopCenter;
            lblPhoneError.Visible = false;
            // 
            // mtbPhoneNumber
            // 
            mtbPhoneNumber.AllowPromptAsInput = true;
            mtbPhoneNumber.AnimateReadOnly = false;
            mtbPhoneNumber.AsciiOnly = false;
            mtbPhoneNumber.BackgroundImageLayout = ImageLayout.None;
            mtbPhoneNumber.BeepOnError = false;
            mtbPhoneNumber.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbPhoneNumber.Depth = 0;
            mtbPhoneNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbPhoneNumber.HidePromptOnLeave = true;
            mtbPhoneNumber.HideSelection = true;
            mtbPhoneNumber.Hint = "Celular";
            mtbPhoneNumber.InsertKeyMode = InsertKeyMode.Default;
            mtbPhoneNumber.LeadingIcon = null;
            mtbPhoneNumber.Location = new Point(37, 353);
            mtbPhoneNumber.Mask = "(00) 00000-0000";
            mtbPhoneNumber.MaxLength = 32767;
            mtbPhoneNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbPhoneNumber.Name = "mtbPhoneNumber";
            mtbPhoneNumber.PasswordChar = '\0';
            mtbPhoneNumber.PrefixSuffixText = null;
            mtbPhoneNumber.PromptChar = ' ';
            mtbPhoneNumber.ReadOnly = false;
            mtbPhoneNumber.RejectInputOnFirstFailure = false;
            mtbPhoneNumber.ResetOnPrompt = true;
            mtbPhoneNumber.ResetOnSpace = true;
            mtbPhoneNumber.RightToLeft = RightToLeft.No;
            mtbPhoneNumber.SelectedText = "";
            mtbPhoneNumber.SelectionLength = 0;
            mtbPhoneNumber.SelectionStart = 0;
            mtbPhoneNumber.ShortcutsEnabled = true;
            mtbPhoneNumber.Size = new Size(410, 48);
            mtbPhoneNumber.SkipLiterals = true;
            mtbPhoneNumber.TabIndex = 3;
            mtbPhoneNumber.TabStop = false;
            mtbPhoneNumber.Text = "(  )      -";
            mtbPhoneNumber.TextAlign = HorizontalAlignment.Left;
            mtbPhoneNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbPhoneNumber.TrailingIcon = null;
            mtbPhoneNumber.UseSystemPasswordChar = false;
            mtbPhoneNumber.ValidatingType = null;
            // 
            // mtbName
            // 
            mtbName.AllowPromptAsInput = true;
            mtbName.AnimateReadOnly = false;
            mtbName.AsciiOnly = false;
            mtbName.BackgroundImageLayout = ImageLayout.None;
            mtbName.BeepOnError = false;
            mtbName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbName.Depth = 0;
            mtbName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbName.HidePromptOnLeave = false;
            mtbName.HideSelection = true;
            mtbName.Hint = "Nome Completo";
            mtbName.InsertKeyMode = InsertKeyMode.Default;
            mtbName.LeadingIcon = null;
            mtbName.Location = new Point(37, 185);
            mtbName.Mask = "";
            mtbName.MaxLength = 32767;
            mtbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbName.Name = "mtbName";
            mtbName.PasswordChar = '\0';
            mtbName.PrefixSuffixText = null;
            mtbName.PromptChar = '_';
            mtbName.ReadOnly = false;
            mtbName.RejectInputOnFirstFailure = false;
            mtbName.ResetOnPrompt = true;
            mtbName.ResetOnSpace = true;
            mtbName.RightToLeft = RightToLeft.No;
            mtbName.SelectedText = "";
            mtbName.SelectionLength = 0;
            mtbName.SelectionStart = 0;
            mtbName.ShortcutsEnabled = true;
            mtbName.Size = new Size(410, 48);
            mtbName.SkipLiterals = true;
            mtbName.TabIndex = 1;
            mtbName.TabStop = false;
            mtbName.TextAlign = HorizontalAlignment.Left;
            mtbName.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbName.TrailingIcon = null;
            mtbName.UseSystemPasswordChar = false;
            mtbName.ValidatingType = null;
            // 
            // mtbLoginPage
            // 
            mtbLoginPage.AutoSize = false;
            mtbLoginPage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mtbLoginPage.BackColor = Color.FromArgb(11, 153, 255);
            mtbLoginPage.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            mtbLoginPage.Depth = 0;
            mtbLoginPage.FlatStyle = FlatStyle.Flat;
            mtbLoginPage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtbLoginPage.HighEmphasis = true;
            mtbLoginPage.Icon = Properties.Resources.left_arrow;
            mtbLoginPage.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            mtbLoginPage.Location = new Point(22, 26);
            mtbLoginPage.Margin = new Padding(4, 6, 4, 6);
            mtbLoginPage.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            mtbLoginPage.Name = "mtbLoginPage";
            mtbLoginPage.NoAccentTextColor = Color.Empty;
            mtbLoginPage.Padding = new Padding(5, 0, 10, 0);
            mtbLoginPage.Size = new Size(41, 36);
            mtbLoginPage.TabIndex = 7;
            mtbLoginPage.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            mtbLoginPage.UseAccentColor = false;
            mtbLoginPage.UseVisualStyleBackColor = false;
            mtbLoginPage.Click += mtbLoginPage_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.AutoSize = false;
            btnShowPassword.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowPassword.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnShowPassword.Depth = 0;
            btnShowPassword.HighEmphasis = true;
            btnShowPassword.Icon = Properties.Resources.eye;
            btnShowPassword.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnShowPassword.Location = new Point(408, 438);
            btnShowPassword.Margin = new Padding(4, 6, 4, 6);
            btnShowPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.NoAccentTextColor = Color.Empty;
            btnShowPassword.Size = new Size(39, 39);
            btnShowPassword.TabIndex = 5;
            btnShowPassword.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnShowPassword.UseAccentColor = false;
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // lblLengthValidation
            // 
            lblLengthValidation.AutoSize = true;
            lblLengthValidation.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLengthValidation.ForeColor = Color.Red;
            lblLengthValidation.Location = new Point(39, 495);
            lblLengthValidation.Name = "lblLengthValidation";
            lblLengthValidation.Size = new Size(238, 20);
            lblLengthValidation.TabIndex = 6;
            lblLengthValidation.Text = "● Deve ter entre 8 e 30 caracteres.\r\n";
            lblLengthValidation.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNameError
            // 
            lblNameError.AutoSize = true;
            lblNameError.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNameError.ForeColor = Color.Red;
            lblNameError.Location = new Point(39, 236);
            lblNameError.Name = "lblNameError";
            lblNameError.Size = new Size(114, 20);
            lblNameError.TabIndex = 9;
            lblNameError.Text = "Nome incorreto";
            lblNameError.TextAlign = ContentAlignment.TopCenter;
            lblNameError.Visible = false;
            // 
            // btnRegister
            // 
            btnRegister.AutoSize = false;
            btnRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegister.BackColor = Color.FromArgb(11, 153, 255);
            btnRegister.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegister.Depth = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.HighEmphasis = true;
            btnRegister.Icon = null;
            btnRegister.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRegister.Location = new Point(37, 619);
            btnRegister.Margin = new Padding(4, 6, 4, 6);
            btnRegister.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRegister.Name = "btnRegister";
            btnRegister.NoAccentTextColor = Color.Empty;
            btnRegister.Size = new Size(410, 36);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Cadastrar";
            btnRegister.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegister.UseAccentColor = false;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // mtbPassword
            // 
            mtbPassword.AllowPromptAsInput = true;
            mtbPassword.AnimateReadOnly = false;
            mtbPassword.AsciiOnly = false;
            mtbPassword.BackgroundImageLayout = ImageLayout.None;
            mtbPassword.BeepOnError = false;
            mtbPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbPassword.Depth = 0;
            mtbPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbPassword.HidePromptOnLeave = false;
            mtbPassword.HideSelection = true;
            mtbPassword.Hint = "Senha";
            mtbPassword.InsertKeyMode = InsertKeyMode.Default;
            mtbPassword.LeadingIcon = null;
            mtbPassword.Location = new Point(37, 435);
            mtbPassword.Mask = "";
            mtbPassword.MaxLength = 32767;
            mtbPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbPassword.Name = "mtbPassword";
            mtbPassword.PasswordChar = '●';
            mtbPassword.PrefixSuffixText = null;
            mtbPassword.PromptChar = '_';
            mtbPassword.ReadOnly = false;
            mtbPassword.RejectInputOnFirstFailure = false;
            mtbPassword.ResetOnPrompt = true;
            mtbPassword.ResetOnSpace = true;
            mtbPassword.RightToLeft = RightToLeft.No;
            mtbPassword.SelectedText = "";
            mtbPassword.SelectionLength = 0;
            mtbPassword.SelectionStart = 0;
            mtbPassword.ShortcutsEnabled = true;
            mtbPassword.Size = new Size(364, 48);
            mtbPassword.SkipLiterals = true;
            mtbPassword.TabIndex = 4;
            mtbPassword.TabStop = false;
            mtbPassword.TextAlign = HorizontalAlignment.Left;
            mtbPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbPassword.TrailingIcon = null;
            mtbPassword.UseSystemPasswordChar = false;
            mtbPassword.ValidatingType = null;
            mtbPassword.TextChanged += mtbPassword_TextChanged;
            // 
            // mtbEmail
            // 
            mtbEmail.AllowPromptAsInput = true;
            mtbEmail.AnimateReadOnly = false;
            mtbEmail.AsciiOnly = false;
            mtbEmail.BackgroundImageLayout = ImageLayout.None;
            mtbEmail.BeepOnError = false;
            mtbEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbEmail.Depth = 0;
            mtbEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbEmail.HidePromptOnLeave = false;
            mtbEmail.HideSelection = true;
            mtbEmail.Hint = "Email";
            mtbEmail.InsertKeyMode = InsertKeyMode.Default;
            mtbEmail.LeadingIcon = null;
            mtbEmail.Location = new Point(37, 268);
            mtbEmail.Mask = "";
            mtbEmail.MaxLength = 32767;
            mtbEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbEmail.Name = "mtbEmail";
            mtbEmail.PasswordChar = '\0';
            mtbEmail.PrefixSuffixText = null;
            mtbEmail.PromptChar = '_';
            mtbEmail.ReadOnly = false;
            mtbEmail.RejectInputOnFirstFailure = false;
            mtbEmail.ResetOnPrompt = true;
            mtbEmail.ResetOnSpace = true;
            mtbEmail.RightToLeft = RightToLeft.No;
            mtbEmail.SelectedText = "";
            mtbEmail.SelectionLength = 0;
            mtbEmail.SelectionStart = 0;
            mtbEmail.ShortcutsEnabled = true;
            mtbEmail.Size = new Size(410, 48);
            mtbEmail.SkipLiterals = true;
            mtbEmail.TabIndex = 2;
            mtbEmail.TabStop = false;
            mtbEmail.TextAlign = HorizontalAlignment.Left;
            mtbEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbEmail.TrailingIcon = null;
            mtbEmail.UseSystemPasswordChar = false;
            mtbEmail.ValidatingType = null;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 127);
            label2.Name = "label2";
            label2.Size = new Size(284, 44);
            label2.TabIndex = 1;
            label2.Text = "Começe a buscar e ofertar serviços, \r\ngerencie seus horários.";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 68);
            label1.Name = "label1";
            label1.Size = new Size(218, 49);
            label1.TabIndex = 0;
            label1.Text = "Criar Conta";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 885);
            Controls.Add(panel1);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.MaterialButton btnShowPassword;
        private Label lblLengthValidation;
        private Label lblIncorrectEmail;
        private ReaLTaiizor.Controls.MaterialButton btnRegister;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbEmail;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialButton mtbLoginPage;
        private Label lblNameError;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbName;
        private Label lblPhoneError;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbPhoneNumber;
        private Label lblCaseValidation;
        private Label lblSpecialCharacterValidation;
        private Label lblNumberValidation;
        private Label lblEmailError;
    }
}