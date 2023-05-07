using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Cars_Salesman
{
    class CarSalesman
    {
        static List<Engine> engines;
        static List<Car> cars;

        static void Main(string[] args)
        {
            engines = new List<Engine>();
            cars = new List<Car>();

            int engineNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineNumber; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                Engine currentEngine = GetEngineDetails(parameters);

                engines.Add(currentEngine);
            }

            int carNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < carNumber; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Car currentCar = GetCarDetails(parameters);

                cars.Add(currentCar);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
        static Engine GetEngineDetails(string[] parameters)
        {
            string model = parameters[0];
            int power = int.Parse(parameters[1]);

            int displacement = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out displacement))
            {
                return new Engine(model, power, displacement);
            }
            else if (parameters.Length == 3)
            {
                string efficiency = parameters[2];
                return new Engine(model, power, efficiency);
            }
            else if (parameters.Length == 4)
            {
                string efficiency = parameters[3];
                return new Engine(model, power, int.Parse(parameters[2]), efficiency);
            }
            else
            {
                return new Engine(model, power);
            }
        }
        static Car GetCarDetails(string[] parameters)
        {
            string model = parameters[0];
            string engineModel = parameters[1];
            Engine engine = engines.FirstOrDefault(x => x.Model == engineModel);

            int weight = -1;

            if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
            {
                return new Car(engine, model, weight);
            }
            else if (parameters.Length == 3)
            {
                string color = parameters[2];
                return new Car(model, engine, color);
            }
            else if (parameters.Length == 4)
            {
                string color = parameters[3];
                return new Car(model, engine, int.Parse(parameters[2]), color);
            }
            else
            {
                return new Car(model, engine);
            }
        }
    }
}
