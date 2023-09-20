// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep5 World!");
//     }
// }


using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your fullname: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite Number: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number)) //if the user enters a number this line allows the input to come out on the console
        //but if we remove the ! sign the program keeps asking the user to enter a number it keeps on  printing line 33
        {
            Console.WriteLine("Invalid Number, please enter a valid number: ");
        }
        return number;

    }
    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResults(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the sqaure of your number is {squaredNumber}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);


        DisplayResults(name, squaredNumber);

    }
}



            


    


        
