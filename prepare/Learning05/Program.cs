using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>() {
            new Square("red", 10),
            new Rectangle("green", 10, 20),
            new Circle("blue", 15)
        };
        foreach (Shape shape in shapes) {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}