namespace CorteCerto.App.Pages
{
    partial class EditBarberAvailabilityForm
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
            mtbStartTime = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            mtbEndTime = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            lblStartTimeError = new Label();
            lblEndTimeError = new Label();
            actionPanel.SuspendLayout();
            fieldPanel.SuspendLayout();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Location = new Point(3, 269);
            actionPanel.Size = new Size(443, 64);
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(-418, 18);
            // 
            // btnSave
            // 
            btnSave.Location = new Point(-562, 15);
            // 
            // fieldPanel
            // 
            fieldPanel.Controls.Add(lblEndTimeError);
            fieldPanel.Controls.Add(lblStartTimeError);
            fieldPanel.Controls.Add(label2);
            fieldPanel.Controls.Add(mtbEndTime);
            fieldPanel.Controls.Add(label1);
            fieldPanel.Controls.Add(mtbStartTime);
            fieldPanel.Size = new Size(443, 205);
            // 
            // mtbStartTime
            // 
            mtbStartTime.AllowPromptAsInput = true;
            mtbStartTime.AnimateReadOnly = false;
            mtbStartTime.AsciiOnly = false;
            mtbStartTime.BackgroundImageLayout = ImageLayout.None;
            mtbStartTime.BeepOnError = false;
            mtbStartTime.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbStartTime.Depth = 0;
            mtbStartTime.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbStartTime.HidePromptOnLeave = false;
            mtbStartTime.HideSelection = true;
            mtbStartTime.InsertKeyMode = InsertKeyMode.Default;
            mtbStartTime.LeadingIcon = null;
            mtbStartTime.Location = new Point(16, 36);
            mtbStartTime.Mask = "00:00";
            mtbStartTime.MaxLength = 32767;
            mtbStartTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbStartTime.Name = "mtbStartTime";
            mtbStartTime.PasswordChar = '\0';
            mtbStartTime.PrefixSuffixText = null;
            mtbStartTime.PromptChar = '_';
            mtbStartTime.ReadOnly = false;
            mtbStartTime.RejectInputOnFirstFailure = false;
            mtbStartTime.ResetOnPrompt = true;
            mtbStartTime.ResetOnSpace = true;
            mtbStartTime.RightToLeft = RightToLeft.No;
            mtbStartTime.SelectedText = "";
            mtbStartTime.SelectionLength = 0;
            mtbStartTime.SelectionStart = 0;
            mtbStartTime.ShortcutsEnabled = true;
            mtbStartTime.Size = new Size(408, 48);
            mtbStartTime.SkipLiterals = true;
            mtbStartTime.TabIndex = 0;
            mtbStartTime.TabStop = false;
            mtbStartTime.Text = "  :";
            mtbStartTime.TextAlign = HorizontalAlignment.Left;
            mtbStartTime.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbStartTime.TrailingIcon = null;
            mtbStartTime.UseSystemPasswordChar = false;
            mtbStartTime.ValidatingType = null;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(16, 13);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 1;
            label1.Text = "Horário Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(16, 107);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 3;
            label2.Text = "Horário Encerramento:";
            // 
            // mtbEndTime
            // 
            mtbEndTime.AllowPromptAsInput = true;
            mtbEndTime.AnimateReadOnly = false;
            mtbEndTime.AsciiOnly = false;
            mtbEndTime.BackgroundImageLayout = ImageLayout.None;
            mtbEndTime.BeepOnError = false;
            mtbEndTime.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            mtbEndTime.Depth = 0;
            mtbEndTime.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            mtbEndTime.HidePromptOnLeave = false;
            mtbEndTime.HideSelection = true;
            mtbEndTime.InsertKeyMode = InsertKeyMode.Default;
            mtbEndTime.LeadingIcon = null;
            mtbEndTime.Location = new Point(16, 130);
            mtbEndTime.Mask = "00:00";
            mtbEndTime.MaxLength = 32767;
            mtbEndTime.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            mtbEndTime.Name = "mtbEndTime";
            mtbEndTime.PasswordChar = '\0';
            mtbEndTime.PrefixSuffixText = null;
            mtbEndTime.PromptChar = '_';
            mtbEndTime.ReadOnly = false;
            mtbEndTime.RejectInputOnFirstFailure = false;
            mtbEndTime.ResetOnPrompt = true;
            mtbEndTime.ResetOnSpace = true;
            mtbEndTime.RightToLeft = RightToLeft.No;
            mtbEndTime.SelectedText = "";
            mtbEndTime.SelectionLength = 0;
            mtbEndTime.SelectionStart = 0;
            mtbEndTime.ShortcutsEnabled = true;
            mtbEndTime.Size = new Size(408, 48);
            mtbEndTime.SkipLiterals = true;
            mtbEndTime.TabIndex = 2;
            mtbEndTime.TabStop = false;
            mtbEndTime.Text = "  :";
            mtbEndTime.TextAlign = HorizontalAlignment.Left;
            mtbEndTime.TextMaskFormat = MaskFormat.IncludeLiterals;
            mtbEndTime.TrailingIcon = null;
            mtbEndTime.UseSystemPasswordChar = false;
            mtbEndTime.ValidatingType = null;
            // 
            // lblStartTimeError
            // 
            lblStartTimeError.AutoSize = true;
            lblStartTimeError.ForeColor = Color.Red;
            lblStartTimeError.Location = new Point(16, 87);
            lblStartTimeError.Name = "lblStartTimeError";
            lblStartTimeError.Size = new Size(371, 20);
            lblStartTimeError.TabIndex = 4;
            lblStartTimeError.Text = "Horário de Inicio inválido, deve estar no formato 07:00";
            lblStartTimeError.Visible = false;
            // 
            // lblEndTimeError
            // 
            lblEndTimeError.AutoSize = true;
            lblEndTimeError.ForeColor = Color.Red;
            lblEndTimeError.Location = new Point(16, 181);
            lblEndTimeError.Name = "lblEndTimeError";
            lblEndTimeError.Size = new Size(427, 20);
            lblEndTimeError.TabIndex = 5;
            lblEndTimeError.Text = "Horário de encerramento inválido, deve estar no formato 19:00";
            lblEndTimeError.Visible = false;
            // 
            // EditBarberAvailabilityForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 336);
            Name = "EditBarberAvailabilityForm";
            Text = "EditBarberAvailabilityForm";
            actionPanel.ResumeLayout(false);
            fieldPanel.ResumeLayout(false);
            fieldPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbStartTime;
        private Label label2;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox mtbEndTime;
        private Label label1;
        private Label lblEndTimeError;
        private Label lblStartTimeError;
    }
}