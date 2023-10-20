
public class Scripture
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool WordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        int index = rand.Next(Words.Count);
        Words[index].IsHidden = true;
    }
}
