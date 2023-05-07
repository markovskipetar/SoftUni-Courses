namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double SportCarDefaultFuelConsumption = 10;

        public SportCar(int horsepowers, double fuel)
            : base(horsepowers, fuel)
        {
        }

        public override double FuelConsumption => SportCarDefaultFuelConsumption;
    }
}
