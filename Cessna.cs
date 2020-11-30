using System;

namespace Garage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna runs away.");
        }
    }
}