using System;
using System.Collections.Generic;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;

    public int TotalPoints => totalPoints;

    public void CreateNewGoal(int type)
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished? ");
                int timesToComplete = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(name, description, points, timesToComplete, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine($"Goal '{name}' created successfully!");
        Console.WriteLine($"You have {totalPoints} points.\n");
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{(goals[i].IsCompleted ? 'x' : ' ')}] {goals[i].Name} ({goals[i].Description})" +
                              $"{(goals[i] is ChecklistGoal ? $" —— Currently completed {((ChecklistGoal)goals[i]).TimesCompleted}/{((ChecklistGoal)goals[i]).TimesToComplete}" : "")}");
        }
        Console.WriteLine($"You have {totalPoints} points.\n");
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < goals.Count && !goals[index].IsCompleted)
        {
            goals[index].IsCompleted = true;

            if (goals[index] is ChecklistGoal)
            {
                ((ChecklistGoal)goals[index]).TimesCompleted++;
                if (((ChecklistGoal)goals[index]).TimesCompleted == ((ChecklistGoal)goals[index]).TimesToComplete)
                {
                    totalPoints += goals[index].Points + ((ChecklistGoal)goals[index]).BonusPoints;
                    Console.WriteLine($"Congratulations! You have earned {goals[index].Points + ((ChecklistGoal)goals[index]).BonusPoints} points!");
                    Console.WriteLine($"Bonus Points! You earned {((ChecklistGoal)goals[index]).BonusPoints} extra points!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You have earned {goals[index].Points} points!");
                }
            }
            else
            {
                totalPoints += goals[index].Points;
                Console.WriteLine($"Congratulations! You have earned {goals[index].Points} points!");
            }

            Console.WriteLine($"You now have {totalPoints} points.\n");
        }
        else
        {
            Console.WriteLine("Invalid goal index or goal already completed.\n");
        }
    }

    public void SaveGoalsToFile(string filename)
    {
        FileHandler.SaveToFile(filename, goals);
    }

    public void LoadGoalsFromFile(string filename)
    {
        goals = FileHandler.LoadFromFile(filename);
        totalPoints = goals.Sum(g => g.Points);
    }
}
