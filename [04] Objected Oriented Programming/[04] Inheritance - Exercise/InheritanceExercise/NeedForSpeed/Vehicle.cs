namespace NeedForSpeed
{
    public class Vehicle
    {
        public const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsepowers, double fuel)
        {
            this.Horsepowers = horsepowers;
            this.Fuel = fuel;
            this.FuelConsumption = DefaultFuelConsumption;
        }

        public int Horsepowers { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption { get; set; }

        public void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }
    }
}
