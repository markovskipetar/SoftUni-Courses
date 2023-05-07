using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStartingValue = int.Parse(Console.ReadLine());
            int secondPairStartingValue = int.Parse(Console.ReadLine());
            int firstPairDifference = int.Parse(Console.ReadLine());
            int secondPairDifference = int.Parse(Console.ReadLine());

            int firstPrimeEnd = firstPairStartingValue + firstPairDifference;
            int secondPrimeEnd = secondPairStartingValue + secondPairDifference;

            for (int i = firstPairStartingValue; i <= firstPrimeEnd; i++)
            {
                int currentFirstPrime = i;
                bool isFirstPrime = true;

                for (int temp = 2; temp <= currentFirstPrime / 2; temp++)
                {
                    if (currentFirstPrime % temp == 0)
                    {
                        isFirstPrime = false;
                        break;
                    }
                }

                if (isFirstPrime)
                {
                    for (int j = secondPairStartingValue; j <= secondPrimeEnd; j++)
                    {
                        int currentSecondPrime = j;
                        bool isSecondPrime = true;

                        for (int temp = 2; temp <= currentSecondPrime / 2; temp++)
                        {
                            if (currentSecondPrime % temp == 0)
                            {
                                isSecondPrime = false;
                                break;
                            }
                        }

                        if (isSecondPrime)
                        {
                            Console.WriteLine($"{i}{j}");
                        }
                    }
                }
            }
        }
    }
}
