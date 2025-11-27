namespace CorteCerto.App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnShowPassword = new ReaLTaiizor.Controls.MaterialButton();
            label3 = new Label();
            lblCreateAccount = new LinkLabel();
            lblIncorrectPassword = new Label();
            lblIncorrectEmail = new Label();
            btnLogin = new ReaLTaiizor.Controls.MaterialButton();
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
            panel1.Controls.Add(btnShowPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblCreateAccount);
            panel1.Controls.Add(lblIncorrectPassword);
            panel1.Controls.Add(lblIncorrectEmail);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(mtbPassword);
            panel1.Controls.Add(mtbEmail);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(283, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 497);
            panel1.TabIndex = 0;
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
            btnShowPassword.Location = new Point(408, 305);
            btnShowPassword.Margin = new Padding(4, 6, 4, 6);
            btnShowPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.NoAccentTextColor = Color.Empty;
            btnShowPassword.Size = new Size(39, 39);
            btnShowPassword.TabIndex = 2;
            btnShowPassword.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnShowPassword.UseAccentColor = false;
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 459);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 8;
            label3.Text = "Não tem uma conta?";
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Location = new Point(181, 459);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(86, 20);
            lblCreateAccount.TabIndex = 7;
            lblCreateAccount.TabStop = true;
            lblCreateAccount.Text = "clique aqui!";
            lblCreateAccount.LinkClicked += lblCreateAccount_LinkClicked;
            // 
            // lblIncorrectPassword
            // 
            lblIncorrectPassword.AutoSize = true;
            lblIncorrectPassword.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncorrectPassword.ForeColor = Color.Red;
            lblIncorrectPassword.Location = new Point(37, 353);
            lblIncorrectPassword.Name = "lblIncorrectPassword";
            lblIncorrectPassword.Size = new Size(112, 20);
            lblIncorrectPassword.TabIndex = 6;
            lblIncorrectPassword.Text = "Senha incorreta";
            lblIncorrectPassword.TextAlign = ContentAlignment.TopCenter;
            lblIncorrectPassword.Visible = false;
            // 
            // lblIncorrectEmail
            // 
            lblIncorrectEmail.AutoSize = true;
            lblIncorrectEmail.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIncorrectEmail.ForeColor = Color.Red;
            lblIncorrectEmail.Location = new Point(37, 265);
            lblIncorrectEmail.Name = "lblIncorrectEmail";
            lblIncorrectEmail.Size = new Size(110, 20);
            lblIncorrectEmail.TabIndex = 5;
            lblIncorrectEmail.Text = "Email incorreto";
            lblIncorrectEmail.TextAlign = ContentAlignment.TopCenter;
            lblIncorrectEmail.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.FromArgb(11, 153, 255);
            btnLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLogin.Location = new Point(37, 404);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(410, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
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
            mtbPassword.Location = new Point(37, 302);
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
            mtbPassword.TabIndex = 3;
            mtbPassword.TabStop = false;
            mtbPassword.TextAlign = HorizontalAlignment.Left;
            mtbPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbPassword.TrailingIcon = null;
            mtbPassword.UseSystemPasswordChar = false;
            mtbPassword.ValidatingType = null;
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
            mtbEmail.Location = new Point(37, 214);
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
            label2.Location = new Point(37, 109);
            label2.Name = "label2";
            label2.Size = new Size(319, 44);
            label2.TabIndex = 1;
            label2.Text = "Consulte serviços, faça agendamentos e \r\norganize seus horários";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(292, 49);
            label1.TabIndex = 0;
            label1.Text = "Entrar na Conta";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1395, 682);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Corte Certo";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbEmail;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialButton btnLogin;
        private Label lblIncorrectPassword;
        private Label lblIncorrectEmail;
        private Label label3;
        private LinkLabel lblCreateAccount;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.MaterialButton btnShowPassword;
    }
}
