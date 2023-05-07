
namespace Shapes
{
    public class Tesla : Car, IElectricCar
    {
        public Tesla(string color, string model, int battery)
            : base(color, model)
        {
            this.Battery = battery;
        }

        public int Battery { get; set; }

        public override string Start()
        {
            return "Tesla no sound when start";
        }
    }
}
