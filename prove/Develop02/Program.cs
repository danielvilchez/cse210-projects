using System;

class Program
{
    static void Main(string[] args)
    {
        // Paso 1. Creación de Instancias:
        // Journal es la clase que maneja las entradas del diario.
        // PromptGenerator es la clase que genera preguntas aleatorias para el usuario.
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator(GetDefaultPrompts());

        // Paso 2. Bucle Principal del Menú:
        // Se inicia un bucle principal que representa el menú del programa.
        // El bucle se ejecuta continuamente hasta que el usuario elige salir.
        while (true)
        {
            // Paso 4. Menú Principal
            // Se muestra un menú con cinco opciones numeradas para que el usuario elija.
            // El usuario ingresa el número correspondiente a la opción que desea realizar.
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            // Leer la opción del usuario
            string choice = Console.ReadLine();

            // Paso 5. Manejo de Opciones:
            // Switch maneja le opcion elegida por el usuario
            switch (choice)
            {
                case "1":
                    // Obtener una pregunta aleatoria
                    string prompt = promptGenerator.GetRandomPrompt();
                    
                    // Mostrar la pregunta y obtener la respuesta del usuario
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    // Crear una nueva entrada y agregarla al diario
                    Entry newEntry = new Entry(DateTime.Now.ToString(), prompt, response);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    // Mostrar el Diario
                    Console.WriteLine("Journal Entries");
                    journal.DisplayAll();
                    break;

                case "3":
                    // Solicitar el nombre del archivo y guardar el diario en ese archivo
                    Console.Write("Enter the file name to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    // Solicitar el nombre del archivo y cargar el diario desde ese archivo
                    // Si el usuario elige la opción "4", se solicita al usuario un nombre de archivo.
                    // Se carga el contenido del diario desde ese archivo, reemplazando cualquier entrada actual.
                    Console.Write("Enter the file name to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "5":
                    // Salir del programa
                    // Si el usuario elige la opción "5", se sale del programa.
                    Environment.Exit(0);
                    break;

                default:
                    // Opción no válida
                    Console.WriteLine("Invalid option. Please choose a number between 1 and 5.");
                    break;
            }
        }
    }

    // Método para obtener las indicaciones predeterminadas
    static List<string> GetDefaultPrompts()
    {
        // Lista de preguntas predeterminadas
        return new List<string>
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of your day?",
            "How did you see the hand of the Lord in your life today?",
            "What was the strongest emotion you felt today?",
            "If you could do anything today, what would it be?"
        };
    }
}
