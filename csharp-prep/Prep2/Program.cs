// using System;

// class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         Console.WriteLine("Hello Prep2 World!");
// //     }
// // }

using System;

class Grade

{
     static void Main()
     {
        Console.WriteLine("Enter the  Percentage: ");
        double percentage =double.Parse(Console.ReadLine());
        string letter;
        
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 )
        {
            letter = "B";

        }
        else if (percentage >= 70 )
        {
             letter = "C";
        }
        else if (percentage >= 60 )
        {
              letter = "D";
        }
        else
        {
              letter = "F";
        }

        Console.WriteLine("Your  grade is:  " + letter);
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations you passed this course");
        }
        else
        {
            Console.WriteLine("You did not pass this course Please try next time.");
        }
    }

}

