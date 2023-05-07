using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            int previousSum = 0;
            int maxDifference = 0;

            for (int i = 0; i < pairsCount; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int sum = firstNumber + secondNumber;
                int currentDiff = Math.Abs(sum - previousSum);

                if (i >= 1 && currentDiff > maxDifference)
                {
                    maxDifference = currentDiff;
                }

                previousSum = sum;
            }

            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}
