using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double resto = double.Parse(Console.ReadLine());
            resto *= 100;

            int coins = 0;

            while (resto != 0)
            {
                if (resto >= 200)
                {
                    coins++;
                    resto -= 200;
                }
                else if (resto >= 100)
                {
                    coins++;
                    resto -= 100;
                }
                else if (resto >= 50)
                {
                    coins++;
                    resto -= 50;
                }
                else if (resto >= 20)
                {
                    coins++;
                    resto -= 20;
                }
                else if (resto >= 10)
                {
                    coins++;
                    resto -= 10;
                }
                else if (resto >= 5)
                {
                    coins++;
                    resto -= 5;
                }
                else if (resto >= 2)
                {
                    coins++;
                    resto -= 2;
                }
                else if (resto >= 1)
                {
                    coins++;
                    resto -= 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(coins);
        }
    }
}
