
//the program saves the listed items in the csv file
//once you press enter after choosing option 3 the program allows the user to either view listed items
//or press any key to continue
//even after being propted to press enter key the user can press enter again to go back to the main menu

using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Activity currentActivity = null;

        while (true)
        {
            Console.WriteLine("Choose an activity:\n1. Breathing\n2. Reflection\n3. Listing\n4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    currentActivity = new BreathingActivity();
                    break;
                case 2:
                    currentActivity = new ReflectionActivity();
                    break;
                case 3:
                    currentActivity = new ListingActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            DisplayAnimation();
            currentActivity.Start();
        }
    }

    static void DisplayAnimation()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("-");
        }
        Console.WriteLine();
    }
}
