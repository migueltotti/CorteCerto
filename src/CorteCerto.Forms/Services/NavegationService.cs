using CorteCerto.App.Infra;
using CorteCerto.App.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App.Services;

public class NavegationService : INavegationService
{
    public void NavegateTo<TForm>() where TForm : Form
    {
        var cad = ConfigureDI.serviceProvider.GetService<TForm>();

        if (cad is not null && !cad.IsDisposed)
        {
            cad.Show();
        }
    }
}
