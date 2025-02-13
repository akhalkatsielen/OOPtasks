using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes;

public interface IShape
{
    public string ToString();
    public double Area();
    public double Perimeter();
}
