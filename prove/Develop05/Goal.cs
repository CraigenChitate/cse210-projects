using System;

public abstract class Goal
{
    protected string description;
    protected internal  int points;
    public string Description { get; set; }
    public int Points { get; set; }

    public string Name { get; set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        this.description = description;
        this.points = points;
    }

    public abstract int RecordEvent();

    public abstract string ToSavedString();

    public override string ToString()
    {
        return $"{Name}: {description} - Points: {points}";
    }
}
