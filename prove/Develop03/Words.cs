// Clase que representa una palabra en la Escritura
public class Word
{
    private string _text;        // Variable que almacena el texto de la palabra
    private bool _isHidden;      // Variable que indica si la palabra está oculta o no

    // Constructor que inicializa la palabra y la establece como no oculta
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Método para ocultar la palabra
    public void Hide()
    {
        _isHidden = true;
    }

    // Método para mostrar la palabra
    public void Show()
    {
        _isHidden = false;
    }

    // Método para verificar si la palabra está oculta
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Método para obtener el texto de visualización de la palabra
    public string GetDisplayText()
    {
        return _isHidden ? "______" : _text;
    }
}
