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

using System;
using System.Collections.Generic;
using System.IO;

class JournalEntry  //This class represents an entry in the journal.
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date}: {Prompt}\n{Response}\n";
    }
}

class Journal //This class manages a list of journal entries (List<JournalEntry>).
// It provides methods to add entries, display entries, save the journal to a CSV file, and load the journal from a CSV file.
{
    public List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(string prompt, string response)
    {
        string date = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        JournalEntry entry = new JournalEntry(prompt, response, date);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToCsv(string filename)//the program saves what the user has written in  a csv file 
    {
        try
        {
        using (StreamWriter writer = new StreamWriter(filename, true)) //By passing true as the second parameter, 
        //I have enabled append mode, which means that new entries will be added to the end of the existing 
        //file without overwriting the previous content.
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
        Console.WriteLine("Journal entry has been  saved to CSV file.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving journal: {e.Message}");
    }
    }

    public void LoadFromCsv(string filename)//the progran loads what the user has written to a csv file
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        entries.Add(new JournalEntry(parts[1], parts[2], parts[0]));
                    }
                }
            }
            Console.WriteLine("Journal is loaded from CSV file.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading journal: {e.Message}"); //to provide any errors in details if any
        }
    }
}

class Program //This is the entry point of the application.
//It contains the main menu loop for user interaction.
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
            Console.Write("Enter the your chosen choice (as a number): ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Choose any  prompt from the list:");
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
                        Console.Write("Enter the  name of the file to save the journal (example, journal.csv): ");
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
