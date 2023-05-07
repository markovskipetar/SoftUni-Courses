namespace Shapes
{
    public class Car : ICar
    {
        public Car(string color, string model)
        {
            this.Color = color;
            this.Model = model;
        }

        public string Color { get; set; }

        public string Model { get; set; }

        public string Start()
        {
            throw new NotImplementedException();
        }

        //public abstract string Start();

        string ICar.Stop()
        {
            return "Stopped";
        }
    }
}
