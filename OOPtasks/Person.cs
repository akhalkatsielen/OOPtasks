using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtasks;

public class Person 
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"Hello! My name is {Name}";
    }
}
