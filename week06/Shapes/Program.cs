using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle("yellow", 3.7);
        Rectangle rectangle = new Rectangle("blue", 4, 10);
        Square square = new Square("black", 14);

        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(square);

        foreach (Shape addedShapes in shapes)
        {
            string color = addedShapes.GetColor();
            double area = addedShapes.GetArea();

            Console.WriteLine($"The {color} shape has an area of: {area}");
        }
    }
}