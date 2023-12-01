
public class TextNote : Note
{
    private string Content { get; set; }

    public TextNote(string title, DateTime creationDate, string content)
    {
        Title = title;
        CreationDate = creationDate;
        Content = content;
    }

    public override void DisplayContent()
    {
        base.DisplayContent();
        Console.WriteLine($"Content: {Content}");
    }
}
