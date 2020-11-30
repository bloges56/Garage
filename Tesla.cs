using System;

namespace Garage
{
    public class Tesla : Vehicle// Electric car
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zooms away.");
        }
    }
}