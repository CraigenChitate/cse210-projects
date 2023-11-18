public abstract class CompletableGoal : Goal
{
    protected internal bool isComplete;

    public CompletableGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isComplete = false;
    }

    public CompletableGoal(string savedString)
        : base("", "", 0)
    {
       
        isComplete = false; 
    }

    public abstract override int RecordEvent();

    public override string ToSavedString()
    {
        
        return ""; 
    }

    public override string ToString()
    {
        return base.ToString() + $" - Completed: {isComplete}";
    }
}
