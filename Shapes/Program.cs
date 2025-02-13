using System;

namespace Shapes;
internal class Program
{
    static void Main(string[] args)
    {
        var rectangle = new Rectangle(2, 3);

        Console.WriteLine(rectangle.Area());
        Console.WriteLine(rectangle.Perimeter());

        var circle = new Circle(3);

        Console.WriteLine(circle.Area());
        Console.WriteLine(circle.Perimeter());

        var square = new Square(5);

        Console.WriteLine(square.Area());
        Console.WriteLine(square.Perimeter());
    }
}