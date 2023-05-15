using System;

class Program
{
    static void Main(string[] args)
    {
        Square fSquare = new Square(8.0, "blue");
        Console.WriteLine($"Color of the Square: {fSquare.GetColor()}");
        Console.WriteLine($"Area of the Square: {fSquare.GetArea()}");
        
        Rectangle fRectangle = new Rectangle(4, 4, "red");
        Console.WriteLine($"Color of the Rectangle: {fRectangle.GetColor()}");
        Console.WriteLine($"Area of the Rectangle: {fRectangle.GetArea()}");
        
        Circle fCircle = new Circle(5, "Black");
        Console.WriteLine($"Color of the Circle: {fCircle.GetColor()}");
        Console.WriteLine($"Area of the Circle: {fCircle.GetArea()}");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(fCircle);
        shapes.Add(fRectangle);
        shapes.Add(fSquare);

        foreach (Shape s in shapes)
        {
            
            string shapeColor = s.GetColor();

           
            double shapeArea = s.GetArea();

            Console.WriteLine($"The {shapeColor} shape has an area of {shapeArea}.");
        }
    }
}