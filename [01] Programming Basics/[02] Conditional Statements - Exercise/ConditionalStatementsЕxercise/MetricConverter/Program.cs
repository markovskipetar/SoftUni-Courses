using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string convertedFrom = Console.ReadLine();
            string convertedTo = Console.ReadLine();

            if(convertedFrom == "cm")
            {
                number /= 100;
            }
            else if (convertedFrom == "mm")
            {
                number /= 1000;
            }

            if (convertedTo == "cm")
            {
                number *= 100;
            }
            else if (convertedTo == "mm")
            {
                number *= 1000;
            }

            Console.WriteLine($"{number:F3}");
        }
    }
}
