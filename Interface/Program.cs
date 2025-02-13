using System;
using System.Drawing;

namespace Interface;
internal class Program
{
    static void Main(string[] args)
    {
        var mercedes = new Car(20);

        mercedes.Drive();

        Console.WriteLine("The car is at gas station");

        mercedes.Refuel(50);
        mercedes.Drive();
    }
}