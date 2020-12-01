using System;

namespace Garage
{
    public class Ram : Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives away.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The truck screeches to a stop.");
        }
    }
}