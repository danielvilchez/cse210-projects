// Reference almacena la información sobre la referencia de la Escritura
public class Reference
{
    private string _book;       // Variable que almacena el nombre del libro
    private int _chapter;        // Variable que almacena el número del capítulo
    private int _verse;          // Variable que almacena el número del versículo inicial
    private int _endVerse;       // Variable que almacena el número del versículo final (si es un rango)

    // Constructor para una sola referencia de versículo
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Para el caso de un solo versículo, el final es igual al inicio
    }

    // Constructor para un rango de versículos
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Método para obtener el texto de visualización de la referencia
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
