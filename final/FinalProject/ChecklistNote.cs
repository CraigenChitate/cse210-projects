using System;
using System.Collections.Generic;

public class ChecklistNote : Note
{
    private List<string> _items { get; set; }

    public ChecklistNote(string title, DateTime creationDate, List<string> items)
        : base(title, creationDate)
    {
        _items = items;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nItems: {string.Join(", ", _items)}";
    }
}