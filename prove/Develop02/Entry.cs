public class Entry
{
    public string _date;
    public string _prompText;
    public string _entryText;

    // Constructor para inicializar una nueva entrada con fecha, pregunta y respuesta.
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _prompText = promptText;
        _entryText = entryText;
    }
}
