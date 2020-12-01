using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectric// Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zooms away.");
        }

        public override void Stop()
        {
            Console.WriteLine("The tesla silently stops.");
        }
    }
}