using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string countryBudget = Console.ReadLine();
                double currentBudget = 0;

                if (countryBudget != "End")
                {
                    currentBudget = double.Parse(countryBudget);
                }
                else
                {
                    break;
                }

                double moneySaved = 0;

                string moneyEarned = Console.ReadLine();

                while (moneyEarned != "End")
                {
                    moneySaved += double.Parse(moneyEarned);

                    if (moneySaved >= currentBudget)
                    {
                        Console.WriteLine($"Going to {input}!");
                        break;
                    }

                    moneyEarned = Console.ReadLine();
                }

                if (moneyEarned == "End")
                {
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
