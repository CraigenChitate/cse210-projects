public class ChecklistGoal : CompletableGoal
{
    private int bonusAmount;
    private int timesCompleted;
    private int timesToComplete;

    public ChecklistGoal(string name, string description, int points, int timesToComplete, int bonusAmount)
        : base(name, description, points)
    {
        this.timesToComplete = timesToComplete;
        this.bonusAmount = bonusAmount;
        timesCompleted = 0;
    }

    public ChecklistGoal(string savedString)
        : base(savedString)
    {
        
    }

    public override int RecordEvent()
    {
        if (!isComplete)
        {
            timesCompleted++;
            if (timesCompleted == timesToComplete)
            {
                isComplete = true;
                return points + bonusAmount;
            }
            return points;
        }
        return 0; 
    }

    public override string ToSavedString()
    {
        
        return ""; 
    }

    public override string ToString()
    {
        return base.ToString() + $" - Completed {timesCompleted}/{timesToComplete} times";
    }
}
