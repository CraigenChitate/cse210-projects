// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Prep1 World!");
//     }
// }

  using System;

  class FullName 
  {
     static void Main()
     {


        Console.Write("What is your First Name?");
        string FirstName = Console.ReadLine();



        Console.Write("What is your Last Name?");
        string LastName = Console.ReadLine();

        string fullName = $"{LastName}, {FirstName}, {LastName}";


        Console.WriteLine($"Your name is {fullName}");
    }
}

