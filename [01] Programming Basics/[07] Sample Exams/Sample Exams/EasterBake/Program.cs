using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBreads = int.Parse(Console.ReadLine());

            double sugerUsed = 0;
            double flourUsed = 0;

            int maxSugar = 0;
            int maxFlour = 0;

            for (int i = 0; i < easterBreads; i++)
            {
                int currentSugarUsed = int.Parse(Console.ReadLine());
                int currentFlavorUsed = int.Parse(Console.ReadLine());

                if (currentSugarUsed > maxSugar)
                {
                    maxSugar = currentSugarUsed;
                }

                if (currentFlavorUsed > maxFlour)
                {
                    maxFlour = currentFlavorUsed;
                }

                sugerUsed += currentSugarUsed;
                flourUsed += currentFlavorUsed;
            }

            double packetsSugar = Math.Ceiling(sugerUsed / 950);
            double packetsFlour = Math.Ceiling(flourUsed / 750);

            Console.WriteLine($"Sugar: {packetsSugar}");
            Console.WriteLine($"Flour: {packetsFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
