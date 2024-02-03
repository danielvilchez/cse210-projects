using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    // Contadores para el seguimiento de las actividades
    static int breathingActivityCount = 0;
    static int reflectingActivityCount = 0;
    static int listingActivityCount = 0;

    static void Main()
    {
        while (true)
        {
            // Mostrar las opciones del menú
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Show activity counts");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;
                case "2":
                    StartReflectingActivity();
                    break;
                case "3":
                    StartListingActivity();
                    break;
                case "4":
                    ShowActivityCounts();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    // Método para iniciar la actividad de respiración
    static void StartBreathingActivity()
    {
        // Incrementar el contador de la actividad
        UpdateActivityCount(ref breathingActivityCount);

        Console.WriteLine("\nWelcome to the Breathing Activity.");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        for (int i = 0; i < duration; i += 6)
        {
            Console.Write("\nBreath in... ");
            Countdown(3);
            Console.Write("\nBreath out...");
            Countdown(i == 0 ? 3 : 6);
            Console.WriteLine();
        }

        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {duration} seconds of the Breathing Activity.");
        ShowSpinner(3);
    }

    // Método para iniciar la actividad de reflexión
    static void StartReflectingActivity()
    {
        // Incrementar el contador de la actividad
        UpdateActivityCount(ref reflectingActivityCount);

        Console.WriteLine("\nWelcome to the Reflecting Activity.");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine("— Think of a time when you did something really difficult. —");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("You may begin in: ");
        CountdownFrom(4);
        Console.WriteLine();

        Console.Write("How did you feel when it was complete? ");
        SlowShowSpinner(3);

        Console.Write("What is your favorite thing about this experience? ");
        SlowShowSpinner(3);

        Console.WriteLine("\nWell done!");
        SlowShowSpinner(3);
        Console.WriteLine($"You have completed another {duration} seconds of the Reflecting Activity.");
        SlowShowSpinner(3);
    }

    // Método para iniciar la actividad de listado
    static void StartListingActivity()
    {
        // Incrementar el contador de la actividad
        UpdateActivityCount(ref listingActivityCount);

        Console.WriteLine("\nWelcome to the Listing Activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("Get ready...\n");

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("--- When have you felt the Holy Ghost this month? ---");

        Console.Write("You may begin in: ");
        CountdownFrom(4);
        Console.WriteLine();

        List<string> userResponses = new List<string>();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"{i}. ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
                userResponses.Add(userInput);
            else
                break;  // Break if the user enters an empty line
        }

        Console.WriteLine("\nYou listed 4 items!");

        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {duration} seconds of the Listing Activity.");
        ShowSpinner(3);
    }

    // Método para mostrar el spinner de carga
    static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(200);
            Console.Write("\b \b|");
            Thread.Sleep(200);
            Console.Write("\b \b/");
            Thread.Sleep(200);
            Console.Write("\b \b-");
            Thread.Sleep(200);
            Console.Write("\b \b\\");
        }
        Console.WriteLine();
    }

    // Método para mostrar el spinner de carga más lento
    static void SlowShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(500);
            Console.Write("\b \b|");
            Thread.Sleep(500);
            Console.Write("\b \b/");
            Thread.Sleep(500);
            Console.Write("\b \b-");
            Thread.Sleep(500);
            Console.Write("\b \b\\");
        }
        Console.WriteLine();
    }

    // Método para la cuenta regresiva desde un número específico
    static void CountdownFrom(int start)
    {
        for (int i = start; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);

            if (i > 1)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            else
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(" ");
            }
        }
    }

    // Método para la cuenta regresiva normal
    static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);

            if (i > 1)
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            else
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(" ");
            }
        }
    }

    // Método para mostrar los contadores de actividad
    static void ShowActivityCounts()
    {
        // Mostrar el número de veces que se han realizado cada actividad
        Console.WriteLine("\nTimes the activities have been performed:");
        Console.WriteLine($"Breathing Activity: {breathingActivityCount}");
        Console.WriteLine($"Reflecting Activity: {reflectingActivityCount}");
        Console.WriteLine($"Listing Activity: {listingActivityCount}\n");
    }

    // Método para incrementar el contador de actividad
    static void UpdateActivityCount(ref int count)
    {
        count++;
    }
}