using System;
using System.Collections.Generic;

public class NoteManager
{
    private List<Note> _notes { get; set; }

    public NoteManager()
    {
        _notes = new List<Note>();
    }

    public void AddNote(Note note)
    {
        _notes.Add(note);
    }

    public void DisplayAllNotes()
    {
        Note.DisplayAllNotes(_notes.ToArray());
    }
}
