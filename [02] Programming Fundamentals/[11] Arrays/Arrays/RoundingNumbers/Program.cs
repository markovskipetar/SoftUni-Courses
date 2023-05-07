using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (double currentNumber in numbers)
            {
                int roundedNumber = (int)Math.Round(currentNumber, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{currentNumber} => {roundedNumber}");
            }
        }
    }
}
