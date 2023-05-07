namespace VehicleCatalogue
{
    using System.Linq;
    using System.Collections.Generic;

    public class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public void OrderByBrand()
        {
            this.Cars = Cars.OrderBy(car => car.Brand).ToList();
            this.Trucks = Trucks.OrderBy(truck => truck.Brand).ToList();
        }
    }
}
