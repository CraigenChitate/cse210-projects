using System;

class Program
{
    static void Main(string[] args)
    {
      
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

       
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3 Problems 8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfor());
    
    }
}
