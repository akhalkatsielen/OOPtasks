using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public class Circle : Shape
{
    protected double radius;
    private double PI = Math.PI;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        double area = PI * Math.Pow(radius, 2);
        return area;
    }

    public override double Perimeter()
    {
        double perimeter = 2 * PI * radius;
        return perimeter;
    }
}
