using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double edgeInRadians = double.Parse(Console.ReadLine());

            double edgeInDegrees = edgeInRadians * 180 / Math.PI;

            Console.WriteLine(Math.Round(edgeInDegrees));
        }
    }
}
