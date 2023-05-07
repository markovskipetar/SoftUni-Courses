using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumberA = int.Parse(Console.ReadLine());
            int inputNumberB = int.Parse(Console.ReadLine());

            if (inputNumberA > inputNumberB)
            {
                Console.WriteLine(inputNumberA);
            }
            else
            {
                Console.WriteLine(inputNumberB);
            }
        }
    }
}
