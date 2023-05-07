using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int scrpitWritersCount = int.Parse(Console.ReadLine());
            double scripWriterClothesPrice = double.Parse(Console.ReadLine());

            movieBudget *= 0.90;

            double moneyForScriptWriters = scripWriterClothesPrice * scrpitWritersCount;

            if (scrpitWritersCount > 150)
            {
                moneyForScriptWriters *= 0.90;
            }

            if (movieBudget >= moneyForScriptWriters)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - moneyForScriptWriters:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyForScriptWriters - movieBudget:F2} leva more.");
            }
        }
    }
}
