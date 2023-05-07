using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeNumsSum = 0;
            int nonPrimeNumsSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }

                
                int number = int.Parse(input);

                if (number < 0 )
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool nonPrime = false;

                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            nonPrime = true;
                            break;
                        }
                    }

                    if (nonPrime)
                    {
                        nonPrimeNumsSum += number;
                    }
                    else
                    {
                        primeNumsSum += number;
                    }
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumsSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNumsSum}");
        }
    }
}
