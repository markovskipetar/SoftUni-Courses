using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameMoves = int.Parse(Console.ReadLine());

            double from0To9 = 0;
            double from10To19 = 0;
            double from20To29 = 0;
            double from30To39 = 0;
            double from40To50 = 0;
            double invalidNumbers = 0;
            double total = 0;

            for (int i = 0; i < gameMoves; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 0 || currentNumber > 50)
                {
                    invalidNumbers++;
                    total /= 2.0;
                }
                else if (0 <= currentNumber && currentNumber <= 9)
                {
                    from0To9++;
                    total += 0.2 * currentNumber;
                }
                else if (10 <= currentNumber && currentNumber <= 19)
                {
                    from10To19++;
                    total += 0.3 * currentNumber;
                }
                else if (20 <= currentNumber && currentNumber <= 29)
                {
                    from20To29++;
                    total += 0.4 * currentNumber;
                }
                else if (30 <= currentNumber && currentNumber <= 39)
                {
                    from30To39++;
                    total += 50;
                }
                else if (40 <= currentNumber && currentNumber <= 50)
                {
                    from40To50++;
                    total += 100; ;
                }
            }

            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"From 0 to 9: {from0To9 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {from10To19 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {from20To29 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {from30To39 / gameMoves * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {from40To50 / gameMoves * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumbers / gameMoves * 100:f2}%");
        }
    }
}
