
public class UserInterface
{
    public void AddNote(NoteManager noteManager, Note note)
    {
        noteManager.AddNote(note);
    }

    public void DisplayAllNotes(NoteManager noteManager)
    {
        noteManager.DisplayAllNotes();
    }
}
