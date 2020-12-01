using System;

namespace Garage
{
    public interface IElectric
    {
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery();
    }
}