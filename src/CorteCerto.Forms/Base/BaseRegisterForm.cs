using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace CorteCerto.App.Base;

public partial class BaseRegisterForm : MaterialForm
{
    #region Methods
    public BaseRegisterForm()
    {
        InitializeComponent();
    }

    protected void ClearFields()
    {
        foreach (var control in fieldPanel.Controls)
        {
            if (control is MaterialTextBoxEdit textBox)
                textBox.Clear();

            if (control is MaterialMaskedTextBox maskedTextBox)
                maskedTextBox.Clear();
        }
    }

    protected virtual void Save()
    {
    }

    #endregion

    #region Events
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure cancel?", "IFSP Store",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            ClearFields();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        Save();
    }

    #endregion
}
