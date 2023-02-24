using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow",3);
        System.Console.WriteLine(square.GetColor());
        System.Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("light blue", 2, 3);
        System.Console.WriteLine(rectangle.GetColor());
        System.Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("teal", 2);
        System.Console.WriteLine(circle.GetColor());
        System.Console.WriteLine(circle.GetArea());
        // using a list of objects
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes){
            System.Console.WriteLine(shape.GetColor());
            System.Console.WriteLine(shape.GetArea());
        }
    }
}