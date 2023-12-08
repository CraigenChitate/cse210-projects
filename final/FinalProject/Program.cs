
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        NoteManager noteManager = new NoteManager();

        while (true)
        {
            Console.WriteLine("1. Add Text Note");
            Console.WriteLine("2. Add Checklist Note");
            Console.WriteLine("3. Add Reminder");
            Console.WriteLine("4. Display All Notes");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter text for the note: ");
                    string text = Console.ReadLine();
                    TextNote textNote = new TextNote("Text Note", DateTime.Now, text);
                    noteManager.AddNote(textNote);
                    break;

                case "2":
                    Console.Write("Enter checklist items (comma-separated): ");
                    string checklistInput = Console.ReadLine();
                    List<string> checklistItems = new List<string>(checklistInput.Split(','));
                    ChecklistNote checklistNote = new ChecklistNote("Checklist Note", DateTime.Now, checklistItems);
                    noteManager.AddNote(checklistNote);
                    break;

                case "3":
                    Console.Write("Enter reminder text: ");
                    string reminderText = Console.ReadLine();
                    Console.Write("Enter reminder date (yyyy-MM-dd HH:mm): ");
                    DateTime reminderDate = DateTime.Parse(Console.ReadLine());
                    ReminderNote reminder = new ReminderNote("Reminder", DateTime.Now, reminderDate, reminderText);
                    noteManager.AddNote(reminder);
                    break;

                case "4":
                    noteManager.DisplayAllNotes();
                    break;

                case "5":
                    Console.WriteLine("Exiting program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
