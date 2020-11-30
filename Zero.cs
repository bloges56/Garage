using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero darts away.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The motorcycle drifts to the {direction}.");
        }
    }
}