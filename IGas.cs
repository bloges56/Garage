namespace Garage
{
    public interface IGas
    {
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank();
    }
}