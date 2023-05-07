namespace VehicleCatalogue
{
    public class Car
    {
        public Car(string brand, string model, int horsepowers)
        {
            this.Brand = brand;
            this.Model = model;
            this.Horsepowers = horsepowers;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepowers { get; set; }
    }
}
