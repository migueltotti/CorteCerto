namespace CorteCerto.App.Pages
{
    partial class RegisterServiceForm
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
            mtbName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbDescription = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbDuration = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            mtbPrice = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            actionPanel.SuspendLayout();
            fieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Location = new Point(3, 408);
            actionPanel.Size = new Size(599, 64);
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(436, 15);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(298, 15);
            // 
            // fieldPanel
            // 
            fieldPanel.Controls.Add(mtbPrice);
            fieldPanel.Controls.Add(mtbDuration);
            fieldPanel.Controls.Add(mtbDescription);
            fieldPanel.Controls.Add(mtbName);
            fieldPanel.Size = new Size(599, 344);
            // 
            // mtbName
            // 
            mtbName.AnimateReadOnly = false;
            mtbName.AutoCompleteMode = AutoCompleteMode.None;
            mtbName.AutoCompleteSource = AutoCompleteSource.None;
            mtbName.BackgroundImageLayout = ImageLayout.None;
            mtbName.CharacterCasing = CharacterCasing.Normal;
            mtbName.Depth = 0;
            mtbName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbName.HideSelection = true;
            mtbName.Hint = "Nome do Serviço*";
            mtbName.LeadingIcon = null;
            mtbName.Location = new Point(22, 26);
            mtbName.MaxLength = 32767;
            mtbName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbName.Name = "mtbName";
            mtbName.PasswordChar = '\0';
            mtbName.PrefixSuffixText = null;
            mtbName.ReadOnly = false;
            mtbName.RightToLeft = RightToLeft.No;
            mtbName.SelectedText = "";
            mtbName.SelectionLength = 0;
            mtbName.SelectionStart = 0;
            mtbName.ShortcutsEnabled = true;
            mtbName.Size = new Size(547, 48);
            mtbName.TabIndex = 0;
            mtbName.TabStop = false;
            mtbName.TextAlign = HorizontalAlignment.Left;
            mtbName.TrailingIcon = null;
            mtbName.UseSystemPasswordChar = false;
            // 
            // mtbDescription
            // 
            mtbDescription.AnimateReadOnly = false;
            mtbDescription.AutoCompleteMode = AutoCompleteMode.None;
            mtbDescription.AutoCompleteSource = AutoCompleteSource.None;
            mtbDescription.BackgroundImageLayout = ImageLayout.None;
            mtbDescription.CharacterCasing = CharacterCasing.Normal;
            mtbDescription.Depth = 0;
            mtbDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbDescription.HideSelection = true;
            mtbDescription.Hint = "Descrição*";
            mtbDescription.LeadingIcon = null;
            mtbDescription.Location = new Point(22, 102);
            mtbDescription.MaxLength = 32767;
            mtbDescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbDescription.Name = "mtbDescription";
            mtbDescription.PasswordChar = '\0';
            mtbDescription.PrefixSuffixText = null;
            mtbDescription.ReadOnly = false;
            mtbDescription.RightToLeft = RightToLeft.No;
            mtbDescription.SelectedText = "";
            mtbDescription.SelectionLength = 0;
            mtbDescription.SelectionStart = 0;
            mtbDescription.ShortcutsEnabled = true;
            mtbDescription.Size = new Size(547, 48);
            mtbDescription.TabIndex = 1;
            mtbDescription.TabStop = false;
            mtbDescription.TextAlign = HorizontalAlignment.Left;
            mtbDescription.TrailingIcon = null;
            mtbDescription.UseSystemPasswordChar = false;
            // 
            // mtbDuration
            // 
            mtbDuration.AnimateReadOnly = false;
            mtbDuration.AutoCompleteMode = AutoCompleteMode.None;
            mtbDuration.AutoCompleteSource = AutoCompleteSource.None;
            mtbDuration.BackgroundImageLayout = ImageLayout.None;
            mtbDuration.CharacterCasing = CharacterCasing.Normal;
            mtbDuration.Depth = 0;
            mtbDuration.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbDuration.HideSelection = true;
            mtbDuration.Hint = "Duração em minutos*";
            mtbDuration.LeadingIcon = null;
            mtbDuration.Location = new Point(305, 179);
            mtbDuration.MaxLength = 32767;
            mtbDuration.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbDuration.Name = "mtbDuration";
            mtbDuration.PasswordChar = '\0';
            mtbDuration.PrefixSuffixText = null;
            mtbDuration.ReadOnly = false;
            mtbDuration.RightToLeft = RightToLeft.No;
            mtbDuration.SelectedText = "";
            mtbDuration.SelectionLength = 0;
            mtbDuration.SelectionStart = 0;
            mtbDuration.ShortcutsEnabled = true;
            mtbDuration.Size = new Size(264, 48);
            mtbDuration.TabIndex = 3;
            mtbDuration.TabStop = false;
            mtbDuration.TextAlign = HorizontalAlignment.Left;
            mtbDuration.TrailingIcon = null;
            mtbDuration.UseSystemPasswordChar = false;
            // 
            // mtbPrice
            // 
            mtbPrice.AllowPromptAsInput = true;
            mtbPrice.AnimateReadOnly = false;
            mtbPrice.AsciiOnly = false;
            mtbPrice.BackgroundImageLayout = ImageLayout.None;
            mtbPrice.BeepOnError = false;
            mtbPrice.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbPrice.Depth = 0;
            mtbPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbPrice.HidePromptOnLeave = false;
            mtbPrice.HideSelection = true;
            mtbPrice.Hint = "Preço*";
            mtbPrice.InsertKeyMode = InsertKeyMode.Default;
            mtbPrice.LeadingIcon = null;
            mtbPrice.Location = new Point(22, 179);
            mtbPrice.Mask = "9999,99";
            mtbPrice.MaxLength = 32767;
            mtbPrice.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbPrice.Name = "mtbPrice";
            mtbPrice.PasswordChar = '\0';
            mtbPrice.PrefixSuffixText = null;
            mtbPrice.PromptChar = '_';
            mtbPrice.ReadOnly = false;
            mtbPrice.RejectInputOnFirstFailure = false;
            mtbPrice.ResetOnPrompt = true;
            mtbPrice.ResetOnSpace = true;
            mtbPrice.RightToLeft = RightToLeft.No;
            mtbPrice.SelectedText = "";
            mtbPrice.SelectionLength = 0;
            mtbPrice.SelectionStart = 0;
            mtbPrice.ShortcutsEnabled = true;
            mtbPrice.Size = new Size(264, 48);
            mtbPrice.SkipLiterals = true;
            mtbPrice.TabIndex = 4;
            mtbPrice.TabStop = false;
            mtbPrice.Text = "    ,";
            mtbPrice.TextAlign = HorizontalAlignment.Left;
            mtbPrice.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbPrice.TrailingIcon = null;
            mtbPrice.UseSystemPasswordChar = false;
            mtbPrice.ValidatingType = null;
            // 
            // RegisterServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 475);
            Name = "RegisterServiceForm";
            Text = "RegisterService";
            actionPanel.ResumeLayout(false);
            fieldPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbDescription;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbDuration;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit mtbServicePrice;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbPrice;
    }
}