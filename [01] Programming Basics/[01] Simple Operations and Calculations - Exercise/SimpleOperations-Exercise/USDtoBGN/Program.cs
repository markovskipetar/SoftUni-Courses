using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyInUSD = Double.Parse(Console.ReadLine());
            double moneyInBGN = moneyInUSD * 1.79549;

            Console.WriteLine($"{moneyInBGN:F2}");
        }
    }
}
