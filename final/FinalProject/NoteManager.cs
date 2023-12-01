
using System.Collections.Generic;

public class NoteManager
{
    private List<Note> Notes { get; set; }

    public NoteManager()
    {
        Notes = new List<Note>();
    }

    public void AddNote(Note note)
    {
        Notes.Add(note);
    }

    public void DisplayAllNotes()
    {
        Note.DisplayAllNotes(Notes.ToArray());
    }
}
