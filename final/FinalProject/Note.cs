
using System;

public abstract class Note
{
    protected string Title { get; set; }
    protected DateTime CreationDate { get; set; }

    public virtual void DisplayContent()
    {
        Console.WriteLine($"Title: {Title}\nCreation Date: {CreationDate}");
    }

    public static void DisplayAllNotes(Note[] notes)
    {
        foreach (var note in notes)
        {
            note.DisplayContent();
            Console.WriteLine();
        }
    }
}
