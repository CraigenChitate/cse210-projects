
using System;
using System.Collections.Generic;

public class ChecklistNote : Note
{
    private List<string> Items { get; set; }
    //public List<string> Items { get; protected set; }

    public ChecklistNote(string title, DateTime creationDate, List<string> items)
        : base(title, creationDate)
    {
        Items = items;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nItems: {string.Join(", ", Items)}";
    }
}
