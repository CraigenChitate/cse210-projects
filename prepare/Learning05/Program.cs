// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning05 World!");
//     }
// }

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        // Create instances of Square, Rectangle, and Circle
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        // Add shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

       
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.Color}");
            Console.WriteLine($"Shape area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}
