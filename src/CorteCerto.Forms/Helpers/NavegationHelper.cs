using CorteCerto.App.Infra;
using Microsoft.Extensions.DependencyInjection;

namespace CorteCerto.App.Helpers;

internal static class NavegationHelper
{
    public static void NavegateTo<TForm>() where TForm : Form
    {
        var cad = ConfigureDI.serviceProvider.GetService<TForm>();

        if (cad is not null && !cad.IsDisposed)
        {
            cad.Show();
        }
    }
}
