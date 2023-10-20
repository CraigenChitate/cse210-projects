public class Word
{
    public string Text { get; }

    // A private backing field for the 'IsHidden' property.
    private bool isHidden;

    // A public property to get or set the hidden state of the word.
    public bool IsHidden
    {
        get { return isHidden; }
        set
        {
            isHidden = value;
        }
    }

    // Constructor to initialize the 'Text' and 'IsHidden' properties.
    public Word(string text)
    {
        
        Text = text;
        
        
        isHidden = false;
    }
}




