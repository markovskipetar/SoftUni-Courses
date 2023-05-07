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

            double under200 = 0;
            double between200and399 = 0;
            double between400and599 = 0;
            double between600and799 = 0;
            double biggerOrEqualTo800 = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    under200++;
                }
                else if (200 <= currentNumber && currentNumber <= 399)
                {
                    between200and399++;
                }
                else if (400 <= currentNumber && currentNumber <= 599)
                {
                    between400and599++;
                }
                else if (600 <= currentNumber && currentNumber <= 799)
                {
                    between600and799++;
                }
                else
                {
                    biggerOrEqualTo800++;
                }
            }

            Console.WriteLine($"{under200 / numbersCount * 100:f2}%");
            Console.WriteLine($"{between200and399 / numbersCount * 100:f2}%");
            Console.WriteLine($"{between400and599 / numbersCount * 100:f2}%");
            Console.WriteLine($"{between600and799 / numbersCount * 100:f2}%");
            Console.WriteLine($"{biggerOrEqualTo800 / numbersCount * 100:f2}%");
        }
    }
}

