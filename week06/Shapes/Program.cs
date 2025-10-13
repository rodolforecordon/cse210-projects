using System;

class Program
{
  static void Main(string[] args)
  {
    List<Shape> shapes = new List<Shape>();

    shapes.Add(new Square("red", 3.5));
    shapes.Add(new Rectangle("blue", 4.5, 10));
    shapes.Add(new Circle("yellow", 5));

    foreach (Shape shape in shapes)
    {
      Console.WriteLine($"Color: {shape.GetColor()} --- Area: {shape.GetArea()}");
    }
  }
}