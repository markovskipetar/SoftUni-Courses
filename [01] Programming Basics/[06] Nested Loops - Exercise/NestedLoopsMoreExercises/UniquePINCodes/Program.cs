using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberUpBorder = int.Parse(Console.ReadLine());
            int secondNumberUpBorder = int.Parse(Console.ReadLine());
            int thirdNumberUpBorder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= firstNumberUpBorder; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                for (int j = 2; j <= secondNumberUpBorder; j++)
                {
                    bool isPrime = true;

                    for (int prime = 2; prime < j; prime++)
                    {
                        if (j % prime == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (!isPrime)
                    {
                        continue;
                    }

                    for (int k = 1; k <= thirdNumberUpBorder; k++)
                    {
                        if (k % 2 == 0)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
