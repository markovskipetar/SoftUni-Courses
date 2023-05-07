using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int firstMultiplier = i + 1;
                    int secondMultiplier = j + 1;
                    int sum = firstMultiplier * secondMultiplier;

                    Console.WriteLine($"{firstMultiplier} * {secondMultiplier} = {sum}");
                }
            }
        }
    }
}
