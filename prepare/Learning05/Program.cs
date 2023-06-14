using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 8.2);
        Rectangle rectangle = new Rectangle("Blue", 7.5, 5.65);
        Circle circle = new Circle("Orange", 9.8);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes){
            Console.WriteLine($"The {shape.GetColor()} shape has an area of: {shape.GetArea()}");
        }
    }
}