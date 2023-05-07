using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordTime = double.Parse(Console.ReadLine());
            double distanceToBeSwum = double.Parse(Console.ReadLine());
            double timeForSwimming1m = double.Parse(Console.ReadLine());

            double resistanceTime = ((int)distanceToBeSwum / 15) * 12.5;
            double totalTime = (distanceToBeSwum * timeForSwimming1m) + resistanceTime;

            if (totalTime < worldRecordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecordTime:F2} seconds slower.");
            }
        }
    }
}
