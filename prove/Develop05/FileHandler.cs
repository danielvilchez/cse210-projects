using System;
using System.Collections.Generic;
using System.IO;

public static class FileHandler
{
    public static void SaveToFile(string filename, List<Goal> goals)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in goals)
                {
                    string line = $"{goal.GetType().Name},{goal.Name},{goal.Description},{goal.Points},{goal.IsCompleted}";

                    if (goal is ChecklistGoal checklistGoal)
                    {
                        line += $",{checklistGoal.TimesToComplete},{checklistGoal.BonusPoints},{checklistGoal.TimesCompleted}";
                    }

                    writer.WriteLine(line);
                }
            }

            Console.WriteLine($"Goals saved to file '{filename}'.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals to file: {ex.Message}\n");
        }
    }

    public static List<Goal> LoadFromFile(string filename)
    {
        List<Goal> loadedGoals = new List<Goal>();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');

                    string goalType = values[0];
                    string name = values[1];
                    string description = values[2];
                    int points = int.Parse(values[3]);
                    bool isCompleted = bool.Parse(values[4]);

                    switch (goalType)
                    {
                        case nameof(SimpleGoal):
                            loadedGoals.Add(new SimpleGoal(name, description, points) { IsCompleted = isCompleted });
                            break;
                        case nameof(EternalGoal):
                            loadedGoals.Add(new EternalGoal(name, description, points) { IsCompleted = isCompleted });
                            break;
                        case nameof(ChecklistGoal):
                            int timesToComplete = int.Parse(values[5]);
                            int bonusPoints = int.Parse(values[6]);
                            int timesCompleted = int.Parse(values[7]);
                            loadedGoals.Add(new ChecklistGoal(name, description, points, timesToComplete, bonusPoints)
                            {
                                IsCompleted = isCompleted,
                                TimesCompleted = timesCompleted
                            });
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type: {goalType}. Skipping.");
                            break;
                    }
                }
            }

            Console.WriteLine($"Goals loaded from file '{filename}'.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals from file: {ex.Message}\n");
        }

        return loadedGoals;
    }
}
