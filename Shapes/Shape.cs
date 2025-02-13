using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public abstract class Shape
{
    protected Location Location;
    public abstract double Area();
    public abstract double Perimeter();
}
