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
            int totalSteps = 0;

            while (totalSteps < 10000)
            {
                string input = Console.ReadLine();

                if (input != "Going home")
                {
                    totalSteps += int.Parse(input);
                }
                else
                {
                    totalSteps += int.Parse(input = Console.ReadLine());
                    break;
                }
            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
