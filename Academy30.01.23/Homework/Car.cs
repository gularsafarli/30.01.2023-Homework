using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car : Vehicle
    {
        public int FuelCapacity;
        public int CurrentFuel;

        public Car(string brand, string model, int millage) : base(brand, model, millage)
        {

        }
        public void AddFuel(int litr)
        {
            if (CurrentFuel + litr <= FuelCapacity)
            {
                Console.WriteLine(CurrentFuel += litr);
            }
            else
            {
                Console.WriteLine("Capacity is full");
            }

        }
    }
}
