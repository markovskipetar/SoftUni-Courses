using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForExcursion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int allDays = 0;
            int spendMoneyCount = 0;

            bool is5TimeLimitReached = false;

            while (availableMoney < moneyForExcursion)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                switch (action)
                {
                    case "spend":
                        availableMoney -= money;

                        if (availableMoney < 0)
                        {
                            availableMoney = 0;
                        }
                        spendMoneyCount++;
                        break;

                    case "save":
                        availableMoney += money;
                        spendMoneyCount = 0;
                        break;
                }

                allDays++;

                if (spendMoneyCount >= 5)
                {
                    is5TimeLimitReached = true;
                    break;
                }
            }

            if (is5TimeLimitReached)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(allDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {allDays} days.");
            }
        }
    }
}
