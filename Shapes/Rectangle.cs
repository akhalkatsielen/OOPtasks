using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public class Rectangle : Shape
{
    protected double side1;
    protected double side2;
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    public override double Area()
    {
        double area = side1 * side2;
        return area;
    }
    public override double Perimeter()
    {
        double perimeter = 2 * (side1 + side2);
        return perimeter;
    }
}
