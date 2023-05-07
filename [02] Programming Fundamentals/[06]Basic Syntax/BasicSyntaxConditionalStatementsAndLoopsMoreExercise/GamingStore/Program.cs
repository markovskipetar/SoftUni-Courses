using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());

            double totalSpent = 0;
            bool isOutOfMoney = false;

            while (true)
            {
                string gameName = Console.ReadLine();

                if (gameName == "Game Time")
                {
                    break;
                }

                double gamePrice = 0;
                bool isExisting = true;

                switch (gameName)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;

                    case "CS: OG":
                        gamePrice = 15.99;
                        break;

                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;

                    case "Honored 2":
                        gamePrice = 59.99;
                        break;

                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;

                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;

                    default:
                        isExisting = false;
                        break;
                }

                if (!isExisting)
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    if (availableMoney >= gamePrice)
                    {
                        availableMoney -= gamePrice;
                        Console.WriteLine($"Bought {gameName}");

                        totalSpent += gamePrice;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    if (availableMoney == 0)
                    {
                        Console.WriteLine("Out of money!");
                        isOutOfMoney = true;
                        break;
                    }
                }
            }

            if (!isOutOfMoney)
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${availableMoney:F2}");
            }
        }
    }
}
