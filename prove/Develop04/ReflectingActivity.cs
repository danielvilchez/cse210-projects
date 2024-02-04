using System;

public class ReflectingActivity : Activity
{
    protected override void PerformActivity()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Program.ShowSpinner(3);

        Console.WriteLine("\nConsider the following reflection:");
        Console.WriteLine("— Think of a time when you overcame something really difficult. —");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.Write("You may begin in: ");
        Program.CountdownFrom(4);
        Console.WriteLine();

        Console.Write("How did you feel when it was complete? ");
        Program.SlowShowSpinner(3);

        Console.Write("What is your favorite thing about this experience? ");
        Program.SlowShowSpinner(3);
    }
}
