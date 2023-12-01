
using System.Collections.Generic;

public class ChecklistNote : Note
{
    private List<string> Items { get; set; }

    public ChecklistNote(string title, DateTime creationDate, List<string> items)
    {
        Title = title;
        CreationDate = creationDate;
        Items = items;
    }

    public override void DisplayContent()
    {
        base.DisplayContent();
        Console.WriteLine($"Items: {string.Join(", ", Items)}");
    }
}
