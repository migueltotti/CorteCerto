namespace CorteCerto.App.Base
{
    partial class BaseRegisterForm
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
            actionPanel = new Panel();
            btnCancel = new ReaLTaiizor.Controls.MaterialButton();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            fieldPanel = new Panel();
            actionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.Controls.Add(btnCancel);
            actionPanel.Controls.Add(btnSave);
            actionPanel.Dock = DockStyle.Bottom;
            actionPanel.Location = new Point(3, 490);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(799, 64);
            actionPanel.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.AutoSize = false;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancel.Location = new Point(656, 15);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(130, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancel.UseAccentColor = true;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(518, 15);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(130, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Salvar";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // fieldPanel
            // 
            fieldPanel.Dock = DockStyle.Fill;
            fieldPanel.Location = new Point(3, 64);
            fieldPanel.Name = "fieldPanel";
            fieldPanel.Size = new Size(799, 426);
            fieldPanel.TabIndex = 1;
            // 
            // BaseRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 557);
            Controls.Add(fieldPanel);
            Controls.Add(actionPanel);
            Name = "BaseRegisterForm";
            Text = "BaseRegisterForm";
            actionPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        protected Panel actionPanel;
        protected ReaLTaiizor.Controls.MaterialButton btnCancel;
        protected ReaLTaiizor.Controls.MaterialButton btnSave;
        protected Panel fieldPanel;
    }
}