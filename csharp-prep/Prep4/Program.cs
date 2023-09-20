// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep4 World!");
//     }
// }


using System;
class Program
{ 
    static void Main()
    {
        List<int> numbers = new List<int>();
        int number =0;
        int sum =0;
        int max = int.MinValue;
         


         Console.WriteLine("Enter a list of numbers and enter 0 when done:");

         do
         {
            Console.WriteLine("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number != 0)
                {
                    numbers.Add(number);
                    sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid Input. Please enter a valid number: ");
        }

    } while (number != 0);
    if (numbers.Count > 0)
    {
        double average = (double) (sum/ numbers.Count);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
    else
    {
        Console.WriteLine("No numbers were entered");   
    }
    Console.WriteLine();

    }
}







