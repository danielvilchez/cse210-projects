using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    protected override void PerformActivity()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Program.ShowSpinner(3);
        Console.WriteLine("Get ready...\n");

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("--- When have you felt the Holy Ghost this month? ---");

        Console.Write("You may begin in: ");
        Program.CountdownFrom(4);
        Console.WriteLine();

        List<string> userResponses = new List<string>();

        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"{i}. ");
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
                userResponses.Add(userInput);
            else
                break;
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items!");
    }
}
