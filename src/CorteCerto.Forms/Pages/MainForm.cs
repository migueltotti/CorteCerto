using CorteCerto.App.Interfaces;
using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;
using ReaLTaiizor.Forms;

namespace CorteCerto.App.Pages
{
    public partial class MainForm : MaterialForm
    {
        #region Variables
        private readonly INavegationService _navegationService;
        private readonly ISessionService _sessionService;
        #endregion

        #region Methods
        public MainForm(ICommandMediator commandMediator, IQueryMediator queryMediator, INavegationService navegationService, ISessionService sessionService)
        {
            _navegationService = navegationService;
            _sessionService = sessionService;

            InitializeComponent();

            // Resolve problema do RealTaiizor iniciando o Forms um pouco deslocado para cima
            this.Load += (s, e) =>
            {
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            };
        }

        private void ColorSideBarButtons()
        {
            btnDashboard.ForeColor = Color.Black;
            btnAppoitments.ForeColor = Color.Black;
            btnServices.ForeColor = Color.Black;
            btnBarbers.ForeColor = Color.Black;
            btnReports.ForeColor = Color.Black;
            btnConfigurations.ForeColor = Color.Black;
        }
        #endregion

        #region Events
        private void materialButton1_Click(object sender, EventArgs e)
        {
            _navegationService.NavegateTo<LoginForm>();
            this.Hide();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            ColorSideBarButtons();
        }
    }
}
