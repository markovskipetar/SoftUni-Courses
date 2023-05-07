using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementEqualToTheSumOfOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxValue = int.MinValue;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxValue)
                {
                    maxValue = currentNumber;
                }

                sum += currentNumber;
            }

            sum -= maxValue;

            if (maxValue == sum)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(maxValue - sum)}");
            }
        }
    }
}
