// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep3 World!");
//     }
// }
using System;
using System.Numerics;
class Program
{
        static void Main()
        
        {
              Random random = new Random();
              int number = random.Next(1,101);
              int guessing;
              int attempts = 0;
               Console.WriteLine("Welcome to the guessing number game: ");

               Console.WriteLine("I have picked a number, please guess what number is it!: ");


               do
               {
                   Console.WriteLine("What is your guess?: ");
                   if (int.TryParse(Console.ReadLine(), out guessing))
                   {
                       attempts++;

                       if (guessing < number)
                   {      
                          Console.WriteLine("Higher");
                   }
                       else if (guessing > number)
                   {   
                           Console.WriteLine("Lower");
                   }
                       else
                    {
                            Console.WriteLine("You guessed it right!");
                            Console.WriteLine($"Finally :) It took you {attempts} attempts to guess the correct number"); 
                    }

                }
                else
                {
                    Console.WriteLine("Invalid number, please enter the correct one:");
                }
            } while (guessing != number);
            Console.WriteLine();
        }
}

                

