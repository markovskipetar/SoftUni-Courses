namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double CarDefaultFuelConsumption = 3;

        public Car(int horsepowers, double fuel)
            : base(horsepowers, fuel)
        {
        }

        public override double FuelConsumption => CarDefaultFuelConsumption;
    }
}
