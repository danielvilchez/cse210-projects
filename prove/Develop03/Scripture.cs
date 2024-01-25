// Clase que representa la Escritura completa
// Scripture maneja la Escritura completa, incluyendo la lógica para ocultar palabras.
public class Scripture
{
    private Reference _reference;    // Variable que almacena la referencia de la Escritura
    private List<Word> _words;       // Lista que almacena todas las palabras de la Escritura

    // Constructor que recibe la referencia y el texto de la Escritura
    public Scripture(Reference reference, string text)
    {
        // Inicializar la referencia y la lista de palabras
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    // Método para ocultar un número específico de palabras de manera aleatoria
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex;
            do
            {
                // Seleccionar un índice aleatorio que no esté ya oculto
                randomIndex = random.Next(_words.Count);
            } while (_words[randomIndex].IsHidden());

            // Ocultar la palabra en el índice seleccionado
            _words[randomIndex].Hide();
        }
    }

    // Método para obtener el texto de visualización de la Escritura
    public string GetDisplayText()
    {
        string displayedText = $"{_reference.GetDisplayText()}\n";

        foreach (Word word in _words)
        {
            displayedText += word.GetDisplayText() + " ";
        }

        return displayedText.Trim(); // Eliminar espacio al final
    }

    // Método para verificar si todas las palabras están ocultas
    public bool IsCompletelyHidden()
    {
        // Devuelve true si todas las palabras están ocultas
        return _words.All(word => word.IsHidden());
    }
}
