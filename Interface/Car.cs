using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class Car : IVehicle
{
    private int startingAmount;
    public Car(int startingAmount)
    {
        this.startingAmount = startingAmount;
    }
    public void Drive()
    {
        while (startingAmount > 0) 
        {
            Console.WriteLine("Car is Driving");
            startingAmount -= 5;
        }
        Console.WriteLine("Car has stoped, Please Refuel the car");
    }
    public bool Refuel(int amount)
    {
        startingAmount += amount;
        return true;
    }
}
