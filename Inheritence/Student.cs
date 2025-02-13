using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence;

public class Student : Person
{
    public Student(string name) : base(name)
    {
        
    }
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }
    public void ShowAge()
    {
        Console.WriteLine($"My age is: {Age} years old");
    }
}
