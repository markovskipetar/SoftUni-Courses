using System;

namespace ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            decimal sum = 0M;

            for (int i = 0; i < numbers; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());

                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
