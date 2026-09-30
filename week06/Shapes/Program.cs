using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 10.0, 5.0));
        shapes.Add(new Circle("Green", 3.0));

        Console.Clear();

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
    }
}