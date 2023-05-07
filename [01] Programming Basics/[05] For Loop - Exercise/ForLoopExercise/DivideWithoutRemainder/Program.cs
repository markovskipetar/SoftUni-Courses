using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            double divisbleBy2 = 0;
            double divisbleBy3 = 0;
            double divisbleBy4 = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    divisbleBy2++;
                }

                if (currentNumber % 3 == 0)
                {
                    divisbleBy3++;
                }

                if (currentNumber % 4 == 0)
                {
                    divisbleBy4++;
                }
            }

            Console.WriteLine($"{divisbleBy2 / numbersCount * 100:f2}%");
            Console.WriteLine($"{divisbleBy3 / numbersCount * 100:f2}%");
            Console.WriteLine($"{divisbleBy4 / numbersCount * 100:f2}%");
        }
    }
}

