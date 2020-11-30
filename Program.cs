using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Ram myRam = new Ram()
            {
                MainColor = "blue",
                MaximumOccupancy = 5,
                FuelCapacity = 22
            };

            Tesla myTesla = new Tesla()
            {
                MainColor = "red",
                MaximumOccupancy = 4,
                BatteryKWh = 100
            };

            Cessna myCessna = new Cessna()
            {
                MainColor = "black",
                MaximumOccupancy = 8,
                FuelCapacity = 50
            };

            Zero myZero = new Zero()
            {
                MainColor = "green",
                MaximumOccupancy = 2,
                BatteryKWh = 80
            };
        }
    }
}
