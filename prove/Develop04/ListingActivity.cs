using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> listingPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area") { }

    public override void Start()
    {
        base.Start();
        PerformListingActivity();
    }

    private void PerformListingActivity()
    {
        List<string> listedItems = new List<string>();

        // Simulate user input
        while (true)
        {
            string randomPrompt = listingPrompts[new Random().Next(listingPrompts.Count)];
            Console.WriteLine(randomPrompt);

            Thread.Sleep(5000); // Give time to think

            Console.WriteLine("Please start listing items. Press 'V' to view current items or any other key to continue and enter more items:");

            string inputKey = Console.ReadKey().Key.ToString().ToUpper();
            if (inputKey == "V")
            {
                ShowListedItems(listedItems);
                continue;
            }

            Console.WriteLine("Enter item:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                break; // Exit if the user doesn't input anything
            }
            listedItems.Add(input);
        }

        Console.WriteLine($"You listed {listedItems.Count} items.");

        // Save listed items to a CSV file
        string csvFilePath = "ListedItems.csv";
        SaveToCSV(csvFilePath, listedItems);

        base.End();
    }

    private void SaveToCSV(string filePath, List<string> items)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (string item in items)
                {
                    writer.WriteLine(item);
                }
            }
            Console.WriteLine($"Items saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the items: {ex.Message}");
        }
    }

    private void ShowListedItems(List<string> items)
    {
        Console.WriteLine("Current items:");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
