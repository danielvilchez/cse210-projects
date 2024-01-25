// Program.cs utiliza las clases para interactuar con el usuario.
using System;

class Program
{
    static void Main()
    {
        // Crear referencia y texto de la Escritura
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        // Crear instancia de la Escritura
        Scripture scripture = new Scripture(reference, scriptureText);

        // Bucle principal 'while'
        while (true)
        {
            // Limpiar la consola y mostrar la Escritura
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Solicitar entrada del usuario
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            // Verificar si el usuario quiere salir o todas las palabras están ocultas
            if (userInput.ToLower() == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }

            // Ocultar un número específico de palabras
            scripture.HideRandomWords(1); // Puedes cambiar el número de palabras a ocultar
        }
    }
}
