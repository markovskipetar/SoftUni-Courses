using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanknotesAndCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevaCoins = int.Parse(Console.ReadLine());
            int twoLevaCoins = int.Parse(Console.ReadLine());
            int fiveLevaBanknotes = int.Parse(Console.ReadLine());
            int requiredMoney = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLevaCoins; i++)
            {
                for (int k = 0; k <= twoLevaCoins; k++)
                {
                    for (int m = 0; m <= fiveLevaBanknotes; m++)
                    {
                        int oneLevaCurrentMoney = i * 1;
                        int twoLevaCurrentMoney = k * 2;
                        int fiveLevaCurrentMoney = m * 5;

                        if (oneLevaCurrentMoney + twoLevaCurrentMoney + fiveLevaCurrentMoney == requiredMoney)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {k} * 2 lv. + {m} * 5 lv. = {requiredMoney} lv.");
                        }
                    }
                }
            }
        }
    }
}
