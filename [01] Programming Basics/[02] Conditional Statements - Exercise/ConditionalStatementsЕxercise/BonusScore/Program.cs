using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (number <= 100)
            {
                bonusPoints += 5;
            }
            else if (number > 1000)
            {
                bonusPoints = number * 0.10;
            }
            else
            {
                bonusPoints = number * 0.20;
            }

            if (number % 2 == 0)
            {
                bonusPoints++;
            }

            if (number % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(number + bonusPoints);
        }
    }
}
