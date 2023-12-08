using System;

public class TextNote : Note
{
    private string _content { get; set; }

    public TextNote(string title, DateTime creationDate, string content)
        : base(title, creationDate)
    {
        _content = content;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nContent: {_content}";
    }
}