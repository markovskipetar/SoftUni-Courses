namespace Shapes
{
    public class Seat : Car
    {
        public Seat(string color, string model)
            : base(color, model)
        {
        }

        public override string ICar.Start()
        {
            return "IMA LI SAJDIIII";
        }
    }
}
