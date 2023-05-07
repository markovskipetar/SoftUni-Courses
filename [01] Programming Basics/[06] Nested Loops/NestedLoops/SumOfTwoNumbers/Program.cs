using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isCombinationFound = false;

            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                for (int j = intervalStart; j <= intervalEnd; j++)
                {
                    int sum = i + j;
                    counter++;

                    if (sum == number)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {sum})");
                        isCombinationFound = true;
                        break;
                    }
                }

                if (isCombinationFound)
                {
                    break;
                }
            }

            if (!isCombinationFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {number}");
            }
        }
    }
}
