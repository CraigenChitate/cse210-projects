
//the program add text note, checklist note, adds a reminder and displays all the notes
//the add reminder allows users to add a reminder and also to add the time where the reminder is going to be needed
//the checklist allows the user to enter food items or notes and they also are separated with commas.
//once the user is done the can press 5 to exit

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
                    Reminder reminder = new Reminder(reminderText, DateTime.Now, reminderDate);
                    noteManager.AddNote(reminder);
                    break;

                case "4":
                    UserInterface ui = new UserInterface();
                    ui.DisplayAllNotes(noteManager);
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
