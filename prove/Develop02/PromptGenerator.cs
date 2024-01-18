public class PromptGenerator
{
    public List<string> _prompts;

    // Constructor para inicializar un generador de preguntas con una lista de preguntas.
    public PromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
    }

    // Método para obtener una pregunta aleatoria de la lista de indicaciones.
    public string GetRandomPrompt()
    {
        // Lógica para obtener y devolver una pregunta aleatoria de la lista.
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
