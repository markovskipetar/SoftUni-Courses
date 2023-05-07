using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableEggs = int.Parse(Console.ReadLine());

            bool buyMoreThanAvailable = false;
            int soldEggs = 0;

            while (true)
            {
                string action = Console.ReadLine();

                if (action == "Close")
                {
                    break;
                }

                int amount = int.Parse(Console.ReadLine());

                if (action == "Fill")
                {
                    availableEggs += amount;
                }
                else
                {
                    if (amount > availableEggs)
                    {
                        buyMoreThanAvailable = true;
                        break;
                    }
                    else
                    {
                        availableEggs -= amount;
                        soldEggs += amount;
                    }
                }
            }

            if (buyMoreThanAvailable)
            {
                Console.WriteLine($"Not enough eggs in store!");
                Console.WriteLine($"You can buy only {availableEggs}.");
            }
            else
            {
                Console.WriteLine($"Store is closed!");
                Console.WriteLine($"{soldEggs} eggs sold.");
            }
        }
    }
}
