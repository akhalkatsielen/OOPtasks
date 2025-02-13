using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract;

public abstract class Animal
{
    private string Name;
    public void SetName(string name)
    {
        Name = name;
    }
    public string GetName()
    {
        return Name;
    }
    //SetName(string name), GetName and Eat.
    //public abstract void SetName(string name);
    //public abstract string GetName();
    public abstract string Eat();
}
