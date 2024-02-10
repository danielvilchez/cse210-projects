class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();
        int choice;

        do
        {
            Console.WriteLine($"You have {goalManager.TotalPoints} points.");  // Mostrar los puntos actuales
            Console.WriteLine("Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("The types of Goals are:\n" +
                                  "1. Simple Goal\n" +
                                  "2. Eternal Goal\n" +
                                  "3. Checklist Goal\n" +
                                  "Which type of goal would you like to create? : ");
                    int goalType = int.Parse(Console.ReadLine());
                    goalManager.CreateNewGoal(goalType);
                    break;
                case 2:
                    goalManager.ListGoals();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoalsToFile(saveFilename);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoalsFromFile(loadFilename);
                    break;
                case 5:
                    goalManager.RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    break;
            }

        } while (choice != 6);
    }
}
