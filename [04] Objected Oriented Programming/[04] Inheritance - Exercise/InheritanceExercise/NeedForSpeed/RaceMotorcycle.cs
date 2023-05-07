namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double RaceMotorcycleDefaultFuelConsumption = 8;

        public RaceMotorcycle(int horsepowers, double fuel)
            : base(horsepowers, fuel)
        {
        }

        public override double FuelConsumption => RaceMotorcycleDefaultFuelConsumption;
    }
}
