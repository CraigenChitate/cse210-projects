using System;

class Program
{
    static void Main()
    {
        
        Fraction fraction1 = new Fraction();       
        Fraction fraction2 = new Fraction(5);      
        Fraction fraction3 = new Fraction(3, 4);   

        // Display fractions and decimal values
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

    
        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        fraction2.SetTop(1);
        fraction2.SetBottom(3);

        Console.WriteLine(fraction2.GetFractionString());
       Console.WriteLine(fraction2.GetDecimalValue());
    }
}
