
//the program has a menu for the user to choose what they want to do
//when the user enters a new goal they also have to save it so that it is saved in a txt file
//the program does not fully work as expected but it does work and save the goals as expected
//when the user record an event, the goal is accomplished and they get points 


using System;
using System.Collections.Generic;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main()
    {
      
        Console.WriteLine("Welcome to Goal Tracker!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        ViewGoals();
                        break;
                    case 2:
                        AddGoal();
                        break;
                    case 3:
                        RecordEvent();
                        break;
                    case 4:
                        SaveGoals();
                        break;
                    case 5:
                        LoadGoals();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for playing Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    

    static void ViewGoals()
    {
        Console.WriteLine("\nGoals:");

        foreach (var goal in goals)
        {
            Console.WriteLine(goal);
        }

        Console.WriteLine($"\nTotal Score: {CalculateTotalScore()}");
    }

    static void AddGoal()
    {
        Console.WriteLine("\nAdding a New Goal:");
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Points for the Goal: ");
        int points;
        if (int.TryParse(Console.ReadLine(), out points))
        {
            Console.Write("Choose Goal Type (1. Simple, 2. Eternal, 3. Checklist): ");
            int type;
            if (int.TryParse(Console.ReadLine(), out type))
            {
                Goal goal = null;
                switch (type)
                {
                    case 1:
                        goal = new SimpleGoal(name, description, points);
                        break;
                    case 2:
                        goal = new EternalGoal(name, description, points);
                        break;
                    case 3:
                        Console.Write("Enter Times to Complete: ");
                        int timesToComplete;
                        if (int.TryParse(Console.ReadLine(), out timesToComplete))
                        {
                            Console.Write("Enter Bonus Amount: ");
                            int bonusAmount;
                            if (int.TryParse(Console.ReadLine(), out bonusAmount))
                            {
                                goal = new ChecklistGoal(name, description, points, timesToComplete, bonusAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for Bonus Amount. Goal not added.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for Times to Complete. Goal not added.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid goal type. Goal not added.");
                        break;
                }

                if (goal != null)
                {
                    goals.Add(goal);
                    Console.WriteLine($"Goal '{name}' added successfully!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for Points. Please enter a number.");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("\nRecording an Event:");

        ViewGoals();

        Console.Write("Enter the index of the goal to record an event (for example 0,1,2 etc): ");
        int index;
        if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];
            int pointsEarned = goal.RecordEvent();
            Console.WriteLine($"Event recorded for goal '{goal.Name}'. Earned {pointsEarned} points!");
        }
        else
        {
            Console.WriteLine("Invalid index. Please enter a valid index from the list.");
        }
    }

   static void SaveGoals()
{
    try
    {
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("goals.txt", true)) 
        {
            foreach (var goal in goals)
            {
                file.WriteLine($"{goal.GetType().Name}|{goal.Name}|{goal.Description}|{goal.Points}|{goal.ToSavedString()}");
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

   static void LoadGoals()
{
    try
    {
        // Load goals only if the list is empty
        if (goals.Count == 0)
        {
            using (System.IO.StreamReader file =
                new System.IO.StreamReader("goals.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    Goal goal = CreateGoalFromSavedString(line);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("Goals are already loaded from the previous session.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    static int CalculateTotalScore()
    {
        int totalScore = 0;
        foreach (var goal in goals)
        {
            totalScore += goal.points;
        }
        return totalScore;
    }

    static Goal CreateGoalFromSavedString(string savedString)
{
    string[] parts = savedString.Split('|');

    if (parts.Length > 0)
    {
        string goalType = parts[0];

        switch (goalType)
        {
            case nameof(SimpleGoal):
                return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
                {
                    isComplete = bool.Parse(parts[4])
                };

            default:
                Console.WriteLine($"Unknown goal type: {goalType}. Goal not loaded.");
                break;
                
            }
        }

        return null;
    }
}
