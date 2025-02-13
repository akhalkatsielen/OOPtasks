using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name)
    {
        Name = name;
    }
    public override string ToString()
    {
        return $"Hello my name is: {Name}";
    }
    public void Greet()
    {
        Console.WriteLine("Hello");
    }
    public void SetAge(int age)
    {
       Age = age;
    }
}
