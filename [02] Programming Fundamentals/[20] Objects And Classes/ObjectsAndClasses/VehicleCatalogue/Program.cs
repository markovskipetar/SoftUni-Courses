namespace VehicleCatalogue
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            Catalog vehicleCatalog = new Catalog();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] input = inputLine
                    .Split("/")
                    .ToArray();

                string type = input[0];
                string brand = input[1];
                string model = input[2];

                if (type == "Car")
                {
                    int horsepowers = int.Parse(input[3]);

                    Car car = new Car(brand, model, horsepowers);

                    vehicleCatalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    int weight = int.Parse(input[3]);

                    Truck truck = new Truck(brand, model, weight);

                    vehicleCatalog.Trucks.Add(truck);
                }
            }

            vehicleCatalog.OrderByBrand();

            if (vehicleCatalog.Cars.Count != 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in vehicleCatalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepowers}hp");
                }
            }

            if (vehicleCatalog.Trucks.Count != 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in vehicleCatalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");

                }
            }
        }
    }
}
