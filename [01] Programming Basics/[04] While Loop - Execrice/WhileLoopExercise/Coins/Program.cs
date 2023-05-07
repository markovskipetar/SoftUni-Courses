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
            double change = double.Parse(Console.ReadLine());

            double changeInStotinki = change * 100;
            int coinsCount = 0;

            while(changeInStotinki != 0)
            {
                if (changeInStotinki >= 200)
                {
                    coinsCount++;
                    changeInStotinki -= 200;
                }
                else if (changeInStotinki >= 100)
                {
                    coinsCount++;
                    changeInStotinki -= 100;
                }
                else if (changeInStotinki >= 50)
                {
                    coinsCount++;
                    changeInStotinki -= 50;
                }
                else if (changeInStotinki >= 20)
                {
                    coinsCount++;
                    changeInStotinki -= 20;
                }
                else if (changeInStotinki >= 10)
                {
                    coinsCount++;
                    changeInStotinki -= 10;
                }
                else if (changeInStotinki >= 5)
                {
                    coinsCount++;
                    changeInStotinki -= 5;
                }
                else if (changeInStotinki >= 2)
                {
                    coinsCount++;
                    changeInStotinki -= 2;
                }
                else if (changeInStotinki >= 1)
                {
                    coinsCount++;
                    changeInStotinki -= 1;
                }
            }

            Console.WriteLine(coinsCount);
        }
    }
}
