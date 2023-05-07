using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrassingGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            double gardenArea = double.Parse(Console.ReadLine());
            double moneyForGrass = gardenArea * 7.61;
            double discount = moneyForGrass * (18 * 0.01);
            Console.WriteLine($"The final price is: {moneyForGrass-discount:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
