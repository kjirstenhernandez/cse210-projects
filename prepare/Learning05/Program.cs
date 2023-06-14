using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Square
        Square square = new Square("red", 3.12);
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());

        // Test Rectangle
        Rectangle rectangle = new Rectangle("yellow", 2, 4);
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetColor());

        //Test Circle
        Circle circle = new Circle("purple", .5);
        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());

        // Iterate through list of various shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("green", 4));
        shapes.Add(new Rectangle("red", 2, 4));
        shapes.Add(new Circle("blue", 5));

        foreach (Shape shape in shapes){
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }

    }
}