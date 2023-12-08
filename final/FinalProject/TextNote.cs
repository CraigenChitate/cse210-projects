
using System;

public class TextNote : Note
{
    private string Content { get; set; }
    //public string Content { get; protected set; }

    public TextNote(string title, DateTime creationDate, string content)
        : base(title, creationDate)
    {
        Content = content;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nContent: {Content}";
    }
}