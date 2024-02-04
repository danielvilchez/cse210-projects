using System;

class Program
{
    public static int BreathingActivityCount = 0;
    public static int ReflectingActivityCount = 0;
    public static int ListingActivityCount = 0;

    static void Main()
    {
        while (true)
        {
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
                    new BreathingActivity().Start();
                    break;
                case "2":
                    new ReflectingActivity().Start();
                    break;
                case "3":
                    new ListingActivity().Start();
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

    public static void ShowActivityCounts()
    {
        Console.WriteLine("\nTimes the activities have been performed:");
        Console.WriteLine($"Breathing Activity: {BreathingActivityCount}");
        Console.WriteLine($"Reflecting Activity: {ReflectingActivityCount}");
        Console.WriteLine($"Listing Activity: {ListingActivityCount}\n");
    }

    public static void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            System.Threading.Thread.Sleep(200);
            Console.Write("\b \b|");
            System.Threading.Thread.Sleep(200);
            Console.Write("\b \b/");
            System.Threading.Thread.Sleep(200);
            Console.Write("\b \b-");
            System.Threading.Thread.Sleep(200);
            Console.Write("\b \b\\");
        }
        Console.WriteLine();
    }

    public static void SlowShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b \b\\");
        }
        Console.WriteLine();
    }

    public static void CountdownFrom(int start)
    {
        for (int i = start; i > 0; i--)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000);

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

    public static void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            System.Threading.Thread.Sleep(1000);

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
}
