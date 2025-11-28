namespace CorteCerto.App.Interfaces;

public interface INavegationService
{
    void NavegateTo<TForm>() where TForm : Form;
}
