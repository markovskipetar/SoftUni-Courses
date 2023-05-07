using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int transactionsCount = int.Parse(Console.ReadLine());

            int attempts = 0;
            double totalSum = 0;

            while (attempts < transactionsCount)
            {
                double currentTransaction = double.Parse(Console.ReadLine());

                if (currentTransaction < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                totalSum += currentTransaction;

                Console.WriteLine($"Increase: {currentTransaction:f2}");

                attempts++;
            }

            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
