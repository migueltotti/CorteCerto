using ReaLTaiizor.Forms;

namespace CorteCerto.App.Pages
{
    public partial class CreateAccountForm : MaterialForm
    {
        public CreateAccountForm()
        {
            InitializeComponent();

            // Resolve problema do RealTaiizor iniciando o Forms um pouco deslocado para cima
            this.Load += (s, e) =>
            {
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            };
        }
    }
}
