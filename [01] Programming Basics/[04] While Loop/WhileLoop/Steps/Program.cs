using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            string stepsCount = Console.ReadLine();

            int stepsTotal = 0;
            bool stepsAreReached = false;

            while (stepsCount != "Going home")
            {
                stepsTotal += int.Parse(stepsCount);

                if (stepsTotal >= 10000)
                {
                    stepsAreReached = true;
                    break;
                }

                stepsCount = Console.ReadLine();
            }

            if (!stepsAreReached)
            {
                stepsCount = Console.ReadLine();

                stepsTotal += int.Parse(stepsCount);

                if (stepsTotal >= 10000)
                {
                    stepsAreReached = true;
                }
            }

            if (stepsAreReached)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - stepsTotal} more steps to reach goal.");
            }
        }
    }
}
