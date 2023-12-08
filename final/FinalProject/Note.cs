
using System;

public abstract class Note
{
    protected string Title { get; set; }
    protected DateTime CreationDate { get; set; }
       //public string Title { get; protected set; }
       //public DateTime CreationDate { get; protected set; }

    public Note(string title, DateTime creationDate)
    {
        Title = title;
        CreationDate = creationDate;
    }

    public override string ToString()
    {
        return $"Title: {Title}\nCreation Date: {CreationDate}";
    }

    public static void DisplayAllNotes(Note[] notes)
    {
        foreach (var note in notes)
        {
            Console.WriteLine(note.ToString());
            Console.WriteLine();
        }
    }
}
