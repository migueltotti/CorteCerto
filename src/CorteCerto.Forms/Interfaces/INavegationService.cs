namespace CorteCerto.App.Interfaces;

public interface INavegationService
{
    void NavegateTo<TForm>(Form? MdiParent = null) where TForm : Form;
}
