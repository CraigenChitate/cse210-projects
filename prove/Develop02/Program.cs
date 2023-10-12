// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Develop02 World!");
    // }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning03 World!");
//     }
// }


//The code uses a simple console-based interface for user interaction. 
//When a user chooses to add an entry, they can select a prompt from a 
//list. The program then adds the entry to the journal.
// Entries are displayed in the "Display Journal" option, and the user can save and load the journal to/from CSV files.

// using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save Journal to CSV");
            Console.WriteLine("4. Load Journal from CSV");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your chosen choice (as a number): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choose any prompt from the list:");
                        Console.WriteLine("1. Who was the most interesting person I interacted with today?");
                        Console.WriteLine("2. What was the best part of my day?");
                        Console.WriteLine("3. How did I see the hand of the Lord in my life today?");
                        Console.WriteLine("4. What was the strongest emotion I felt today?");
                        Console.WriteLine("5. If I had one thing I could do over today, what would it be?");
                        Console.Write("Enter the prompt number: ");
                        int promptChoice = int.Parse(Console.ReadLine());
                        Console.Write("Enter your response here: ");
                        string response = Console.ReadLine();
                        string prompt = "";
                        switch (promptChoice)
                        {
                            case 1:
                                prompt = "Who was the most interesting person I interacted with today?";
                                break;
                            case 2:
                                prompt = "What was the best part of my day?";
                                break;
                            case 3:
                                prompt = "How did I see the hand of the Lord in my life today?";
                                break;
                            case 4:
                                prompt = "What was the strongest emotion I felt today?";
                                break;
                            case 5:
                                prompt = "If I had one thing I could do over today, what would it be?";
                                break;
                            default:
                                prompt = "Custom Prompt";
                                break;
                        }
                        journal.AddEntry(prompt, response);
                        break;
                    case 2:
                        Console.WriteLine("\nJournal Entries:\n");
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter the name of the file to save the journal (example, journal.csv): ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToCsv(saveFileName);
                        break;
                    case 4:
                        Console.Write("Enter the filename to load the journal from (example, journal.csv): ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromCsv(loadFileName);
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid selection.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a valid number.");
            }
        }
    }
}
