public class Journal
{
    // Se declara una lista llamada _entries que almacenará objetos de tipo Entry
    // Esta lista es donde se guardarán todas las entradas del diario.
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Método para agregar una nueva entrada al diario.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Método para mostrar todas las entradas del diario.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}\nPrompt: {entry._prompText}\nEntry: {entry._entryText}\n");
        }
    }

    // Método para guardar las entradas del diario en un archivo.
    public void SaveToFile(string file)
    {
        File.WriteAllLines(file, _entries.Select(entry => $"{entry._date},{entry._prompText},{entry._entryText}"));
    }

    // Método para cargar las entradas del diario desde un archivo.
    public void LoadFromFile(string file)
    {
        _entries = File.ReadLines(file)
            .Select(line => line.Split(','))
            .Where(parts => parts.Length == 3)
            .Select(parts => new Entry(parts[0], parts[1], parts[2]))
            .ToList();
    }
}
