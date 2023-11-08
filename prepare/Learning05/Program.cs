using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 5.0));
        shapes.Add(new Rectangle("Blue", 6.0, 4.0));
        shapes.Add(new Circle("Green", 3.0));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The '{color}' shape has an area of {area}.");
        }
    }
}