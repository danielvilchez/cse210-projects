using System;

public class BreathingActivity : Activity
{
    protected override void PerformActivity()
    {
        Console.Write("How long, in seconds, would you like for your session?: ");
        int duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Get ready...");
        Program.ShowSpinner(3);

        for (int i = 0; i < duration; i += 6)
        {
            Console.Write("\nBreathe in... ");
            Program.Countdown(3);
            Console.Write("\nBreath out...");
            Program.Countdown(i == 0 ? 3 : 6);
            Console.WriteLine();
        }
    }
}
