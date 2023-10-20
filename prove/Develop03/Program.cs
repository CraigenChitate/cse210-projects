//modified the program to use more scriptures
//implemented the principles of encapsulation by making some methods private 
//program has a library of scriptures


class Program
{
    //Private field to store the list of Scripture objects(Encapsulation)
    private static List<Scripture> scriptureLibrary = new List<Scripture>
    {
        // Initializing the scriptureLibrary with Scriptures
        new Scripture(new Reference("John 3:16: "), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        new Scripture(new Reference("Alma 1:11 : "), "And it came to pass that he stood before Alma and pled for himself with much boldness."),
        // we can add more  scriptures  as many as we want here
    };

    //Private field to store the Random objects(Encapsulation)
    private static Random random = new Random();

    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorizing Program");

        while (true)
        {
           
            int randIndex = random.Next(scriptureLibrary.Count);  // Getting  a random index to select a random Scripture
            Scripture currentScripture = scriptureLibrary[randIndex];

            
            Console.WriteLine(currentScripture.Reference.VerseReference); // Display the reference for the current Scripture

            while (!currentScripture.WordsHidden())
            {
                Console.WriteLine();
                Console.WriteLine(currentScripture.Reference.VerseReference);

                
                currentScripture.HideRandomWord(); // Hide a random word in the current Scripture when it shows on the screen

                // Create a string with hidden words (underscores) and visible words
                string hideText = string.Join(" ", currentScripture.Words.Select(word => word.IsHidden ? "____" : word.Text));
                Console.WriteLine(hideText);

                Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                    return;

                Console.Clear();
            }
            Console.WriteLine("Congratulations!! You successfully memorized the scripture!");
        }
    }

    // Public method to access the Scripture library
    public static List<Scripture> GetScriptureLibrary()
    {
        return scriptureLibrary;
    }

    // Public method to access the Random object
    public static Random GetRandom()
    {
        return random;
    }
}
