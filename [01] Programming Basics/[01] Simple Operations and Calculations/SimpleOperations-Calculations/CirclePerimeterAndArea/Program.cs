using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            Console.WriteLine($"{Math.PI * Math.Pow(circleRadius, 2):F2}");
            Console.WriteLine($"{2 * Math.PI * circleRadius:F2}");
        }
    }
}
