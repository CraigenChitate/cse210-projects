public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public EternalGoal(string savedString)
        : base("", "", 0)
    {
        
    }

    public override int RecordEvent()
    {
        
        return points; 
    }

    public override string ToSavedString()
    {
        
        return ""; 
    }
}
