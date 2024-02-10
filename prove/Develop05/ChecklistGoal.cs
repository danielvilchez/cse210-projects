public class ChecklistGoal : Goal
{
    public int TimesToComplete { get; set; }
    public int BonusPoints { get; set; }
    public int TimesCompleted { get; set; }

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusPoints)
        : base(name, description, points)
    {
        TimesToComplete = timesToComplete;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }
}
