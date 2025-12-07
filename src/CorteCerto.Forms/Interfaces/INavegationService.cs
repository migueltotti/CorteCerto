namespace CorteCerto.App.Interfaces;

public interface INavegationService
{
    void NavegateTo<TForm>(Form? MdiParent = null, Action<TForm>? initializer = null) where TForm : Form;
}
