using System;

public abstract class Note
{
    protected string _title { get; set; }
    protected DateTime _creationDate { get; set; }

    public Note(string title, DateTime creationDate)
    {
        _title = title;
        _creationDate = creationDate;
    }

    public override string ToString()
    {
        return $"Title: {_title}\nCreation Date: {_creationDate}";
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
