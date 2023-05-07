using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStarts
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetForActors = double.Parse(Console.ReadLine());

            bool isBudgetOver = false;

            string actor = Console.ReadLine();

            while (actor != "ACTION")
            {
                int actorNameLength = actor.Length;

                if (actorNameLength <= 15)
                {
                    double actorHonorarium = double.Parse(Console.ReadLine());

                    budgetForActors -= actorHonorarium;
                }
                else
                {
                    double actorHonorarium = 0.2 * budgetForActors;

                    budgetForActors -= actorHonorarium;
                }

                if (budgetForActors <= 0)
                {
                    isBudgetOver = true;
                    break;
                }

                actor = Console.ReadLine();
            }

            if (isBudgetOver)
            {
                Console.WriteLine($"We need {Math.Abs(budgetForActors):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budgetForActors:f2} leva.");
            }
        }
    }
}
