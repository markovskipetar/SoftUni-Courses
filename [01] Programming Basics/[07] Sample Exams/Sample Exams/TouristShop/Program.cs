using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            bool isBudgetOver = false;
            double requiredMoney = 0;

            int productsCounter = 0;
            double spentMoney = 0;

            while (true)
            {
                string product = Console.ReadLine();

                if (product == "Stop")
                {
                    break;
                }

                double productPrice = double.Parse(Console.ReadLine());

                productsCounter++;

                if (productsCounter % 3 == 0)
                {
                    productPrice /= 2;
                }

                if (productPrice > budget)
                {
                    requiredMoney = productPrice - budget;
                    isBudgetOver = true;
                    break;
                }

                spentMoney += productPrice;
                budget -= productPrice;
            }

            if (isBudgetOver)
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {requiredMoney:f2} leva!");
            }
            else
            {
                Console.WriteLine($"You bought {productsCounter} products for {spentMoney:f2} leva.");
            }
        }
    }
}
