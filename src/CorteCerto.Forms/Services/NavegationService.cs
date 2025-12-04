using CorteCerto.App.Infra;
using CorteCerto.App.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App.Services;

public class NavegationService : INavegationService
{
    private readonly HashSet<Type> _baberProfileRequiredForms;
    private readonly HashSet<Type> _authenticateRequiredForms;
    private readonly ISessionService _sessionService;

    private NavegationService(ISessionService sessionService, HashSet<Type> baberProfileRequiredForms, HashSet<Type> authenticateRequiredForms)
    {
        _baberProfileRequiredForms = baberProfileRequiredForms;
        _authenticateRequiredForms = authenticateRequiredForms;
        _sessionService = sessionService;
    }

    public void NavegateTo<TForm>(Form? MdiParent = null) where TForm : Form
    {
        var cad = ConfigureDI.serviceProvider.GetService<TForm>();

        if (cad is not null && !cad.IsDisposed)
        {
            if (FormNeedAuthenticationAndUserIsNotAuthenticated(cad))
            {
                MessageBox.Show(
                    "Você precisa estar autenticado para acessar esta tela.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (FormNeedBarberProfileAndUserHasNotBarberProfile(cad))
            {
                MessageBox.Show(
                    "Você precisa ter perfil de barbeiro para acessar esta tela.",
                    "Acesso negado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (MdiParent is not null)
            {
                cad.MdiParent = MdiParent;
            }

            cad.Show();
        }
    }

    private bool FormNeedAuthenticationAndUserIsNotAuthenticated<TForm>(TForm form)
    {
        return _authenticateRequiredForms.Contains(typeof(TForm))
            && !_sessionService.IsAuthenticated;
    }

    private bool FormNeedBarberProfileAndUserHasNotBarberProfile<TForm>(TForm form)
    {
        return _baberProfileRequiredForms.Contains(typeof(TForm))
            && !_sessionService.CurrentUserHasBarberProfile();
    }

    public class Builder
    {
        private readonly HashSet<Type> _baberProfileRequiredForms = [];
        private readonly HashSet<Type> _authenticateRequiredForms = [];

        public Builder() { }

        public Builder AddBarberProfileRequiredForms(List<Type> forms)
        {
            _baberProfileRequiredForms.UnionWith(forms);
            _authenticateRequiredForms.UnionWith(forms);

            return this;
        }
        public Builder AddAuthenticateRequiredForms(List<Type> forms)
        {
            _authenticateRequiredForms.UnionWith(forms);

            return this;
        }

        public NavegationService Build(ISessionService service)
        {
            return new NavegationService(service, _baberProfileRequiredForms, _authenticateRequiredForms);
        }
    }
}
