namespace Train
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> wagonsWithPassengers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "end")
                {
                    break;
                }

                if (command == "Add")
                {
                    int currentWagonWithPassenger = int.Parse(input[1]);

                    wagonsWithPassengers.Add(currentWagonWithPassenger);
                }
                else
                {
                    int passengersToAdd = int.Parse(input[0]);

                    FindWagon(wagonsWithPassengers, maxCapacityOfWagon, passengersToAdd);
                }
            }

            Console.WriteLine(String.Join(" ", wagonsWithPassengers));
        }

        static void FindWagon(List<int> wagonsWithPassengers, int maxCapacityOfWagon, int passengersToAdd)
        {
            for (int i = 0; i < wagonsWithPassengers.Count; i++)
            {
                if (maxCapacityOfWagon - wagonsWithPassengers[i] >= passengersToAdd)
                {
                    wagonsWithPassengers[i] += passengersToAdd;

                    break;
                }
            }
        }
    }
}
