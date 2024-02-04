using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected int activityCount = 0;

    public void Start()
    {
        IncrementCount();
        ShowStart();
        PerformActivity();
        ShowCompletion();
    }

    protected abstract void PerformActivity();

    protected void ShowStart()
    {
        Console.WriteLine($"\nWelcome to the {GetType().Name}.");
        Console.WriteLine("This activity will help you relax and focus on the present moment.");
    }

    protected void ShowCompletion()
    {
        Console.WriteLine($"\nWell done! You have completed another session of the {GetType().Name}.");
        Program.ShowSpinner(3);
    }

    protected void IncrementCount()
    {
        activityCount++;
        Program.ShowActivityCounts();
    }
}
