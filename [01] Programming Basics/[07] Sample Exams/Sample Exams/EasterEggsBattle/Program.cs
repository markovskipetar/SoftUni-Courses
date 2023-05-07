using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            bool areFirstPlayerEggsOver = false;
            bool areSecondPlayerEggsOver = false;

            while (true)
            {
                string winner = Console.ReadLine();

                if (winner == "End of battle")
                {
                    break;
                }

                switch (winner)
                {
                    case "one":
                        secondPlayerEggs--;
                        break;

                    case "two":
                        firstPlayerEggs--;
                        break;
                }

                if (firstPlayerEggs <= 0)
                {
                    areFirstPlayerEggsOver = true;
                    break;
                }
                else if (secondPlayerEggs <= 0)
                {
                    areSecondPlayerEggsOver = true;
                    break;
                }
            }

            if (areFirstPlayerEggsOver)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
            }
            else if (areSecondPlayerEggsOver)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
            }
            else
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
        }
    }
}
