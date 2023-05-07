using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());

            int[] allWagons = new int[wagonsCount];
            int passengersCount = 0;

            for (int i = 0; i < wagonsCount; i++)
            {
                int currentWagonPassengers = int.Parse(Console.ReadLine());

                allWagons[i] = currentWagonPassengers;

                passengersCount += currentWagonPassengers;
            }

            Console.WriteLine(String.Join(" ", allWagons));
            Console.WriteLine(passengersCount);
        }
    }
}
