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

            myRam.Drive();
            myRam.Stop();
            myRam.Turn("right");
            Console.WriteLine();

            myTesla.Drive();
            myTesla.Stop();
            myTesla.Turn("right");
            Console.WriteLine();

            myCessna.Drive();
            myCessna.Stop();
            myCessna.Turn("right");
            Console.WriteLine();

            myZero.Drive();
            myZero.Stop();
            myZero.Turn("right");
            Console.WriteLine();

        }
    }
}
