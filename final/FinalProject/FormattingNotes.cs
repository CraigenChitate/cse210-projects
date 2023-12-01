
public static class FormattingNotes
{
    public static string FormatTextNote(string text)
    {
     
        return text;
    }

    public static string FormatChecklistNote(List<string> items)
    {
        
        return string.Join(", ", items);
    }
}
