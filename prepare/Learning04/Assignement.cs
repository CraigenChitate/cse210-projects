using System;

public class Assignment
{
    private string studentName;
    private string topic;

    public Assignment(string studentName, string topic)
    {
        this.studentName = studentName;
        this.topic = topic;
    }

    public string GetSummary()
    {
        return $"{studentName} - {topic}";
    }
}
