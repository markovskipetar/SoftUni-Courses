using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            Console.WriteLine(1);

            for (int i = 1; i < n; i++)
            {
                if (i % 2 == 1)
                {
                    firstArr[0] = 1;
                    firstArr[i] = 1;

                    for (int first = 1; first <= i - 1; first++)
                    {
                        firstArr[first] = secondArr[first] + secondArr[first - 1];
                    }

                    for (int print = 0; print < i + 1; print++)
                    {
                        Console.Write($"{firstArr[print]} ");
                    }
                }
                else
                {
                    secondArr[0] = 1;
                    secondArr[i] = 1;

                    for (int second = 1; second <= i - 1; second++)
                    {
                        secondArr[second] = firstArr[second] + firstArr[second - 1];
                    }

                    for (int print = 0; print < i + 1; print++)
                    {
                        Console.Write($"{secondArr[print]} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
