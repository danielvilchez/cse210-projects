using System;
using System.Collections.Generic;

class TaskManager
{
    static List<Task> tasks = new List<Task>();

    public static void Run()
    {
        Console.WriteLine("Welcome to the Task Management Program!");

        int choice;
        do
        {
            DisplayMenu();
            choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    CreateTask();
                    break;
                case 2:
                    ShowTaskList();
                    break;
                case 3:
                    CompleteTask();
                    break;
                case 4:
                    EditTask();
                    break;
                case 5:
                    DeleteTask();
                    break;
                case 6:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

        } while (choice != 6);
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nTask Manager Program");
        Console.WriteLine("1. Create task");
        Console.WriteLine("2. Show task list");
        Console.WriteLine("3. Complete task");
        Console.WriteLine("4. Edit task");
        Console.WriteLine("5. Delete task");
        Console.WriteLine("6. Exit");
    }

    static int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void CreateTask()
    {
        Console.Write("Name of the task: ");
        string taskName = Console.ReadLine();

        string hasDeadlineInput;
        bool hasValidDeadlineInput;

        do
        {
            Console.Write("Deadline yes/no? (yes/no): ");
            hasDeadlineInput = Console.ReadLine().ToLower();
            hasValidDeadlineInput = hasDeadlineInput == "yes" || hasDeadlineInput == "no";

            if (!hasValidDeadlineInput)
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }

        } while (!hasValidDeadlineInput);

        bool hasDeadline = hasDeadlineInput == "yes";
        DateTime deadline = DateTime.MinValue;

        if (hasDeadline)
        {
            Console.Write("Enter the deadline (format: MM/dd/yyyy HH:mm): ");
            string deadlineInput = Console.ReadLine();

            if (DateTime.TryParseExact(deadlineInput, "MM/dd/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out deadline))
            {
                Console.WriteLine($"Deadline set to: {deadline.ToString("MM/dd/yyyy HH:mm")}");
            }
            else
            {
                Console.WriteLine("Invalid deadline format. Task created without deadline.");
                hasDeadline = false;
            }
        }

        Task newTask;
        newTask = new SimpleTask(taskName, hasDeadline, deadline);

        Console.WriteLine("Task created successfully!");
        tasks.Add(newTask);
    }

    static void ShowTaskList()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks added yet.");
            return;
        }

        Console.WriteLine("Task List:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.Write($"{i + 1}. {tasks[i].Name}");

            if (tasks[i].HasDeadline)
            {
                Console.Write($" (Deadline: {tasks[i].Deadline.ToString("MM/dd/yyyy HH:mm")})");
            }

            if (tasks[i].Completed)
            {
                Console.Write(" - Completed");
            }
            else if (tasks[i].HasDeadline && DateTime.Now > tasks[i].Deadline)
            {
                Console.Write(" - Not Completed (Deadline passed)");
            }

            Console.WriteLine();
        }
    }

    static void CompleteTask()
    {
        ShowTaskList();

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available to complete.");
            return;
        }

        Console.Write("Enter the number of the task you want to complete: ");
        int taskIndex = Convert.ToInt32(Console.ReadLine()) - 1;

        if (taskIndex < 0 || taskIndex >= tasks.Count)
        {
            Console.WriteLine("Invalid task number.");
            return;
        }

        tasks[taskIndex].MarkAsCompleted();
        Console.WriteLine("Task completed successfully!");
    }

    static void EditTask()
    {
        // Implement the logic for editing a task (in progress)
    }

    static void DeleteTask()
    {
        // Delete task in progress
    }
}
