using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Raw_Data
{
    class Program
    {
        static List<Car> cars;
        static void Main(string[] args)
        {
            cars = new List<Car>();

            int carsNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsNumber; i++)
            {
                string[] singleCarInfo = Console.ReadLine().Split().ToArray();

                Car currentCar = GetCarInformation(singleCarInfo);

                cars.Add(currentCar);
            }

            string searchedCargoType = Console.ReadLine();

            List<string> properCarsByCargoType = GetProperCars(searchedCargoType);

            properCarsByCargoType.ForEach(Console.WriteLine);
        }
        static Car GetCarInformation(string[] singleCarInfo)
        {
            string carModel = singleCarInfo[0];
            int engineSpeed = int.Parse(singleCarInfo[1]);
            int enginePower = int.Parse(singleCarInfo[2]);
            int cargoWeight = int.Parse(singleCarInfo[3]);
            string cargoType = singleCarInfo[4];

            int a = 5;
            List<Tire> tires = new List<Tire>();

            for (int tire = 0; tire < 4; tire++)
            {
                double pressure = double.Parse(singleCarInfo[a]);
                int age = int.Parse(singleCarInfo[a + 1]);

                tires.Add(new Tire(age, pressure));

                a += 2;
            }

            return new Car(carModel, new Engine(engineSpeed, enginePower), new Cargo(cargoWeight, cargoType), tires);
        }
        static List<string> GetProperCars(string cargoType)
        {
            List<string> properCars = new List<string>();

            if (cargoType == "fragile")
            {
                properCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1)).Select(x => x.Model).ToList();
            }
            else if (cargoType == "flamable")
            {
                properCars = cars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250).Select(x => x.Model).ToList();
            }

            return properCars;
        }
    }
}
