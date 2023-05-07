using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startingPointsFromAcademy = double.Parse(Console.ReadLine());
            int stuartsCount = int.Parse(Console.ReadLine());

            bool isActorNominated = false;

            for (int i = 0; i < stuartsCount; i++)
            {
                string currentStuartName = Console.ReadLine();
                double pointsFromCurrentStuart = double.Parse(Console.ReadLine());

                int stuartNameLength = currentStuartName.Length;
                double currentPoints = stuartNameLength * pointsFromCurrentStuart / 2;

                startingPointsFromAcademy += currentPoints;

                if (startingPointsFromAcademy > 1250.5)
                {
                    isActorNominated = true;
                    break;
                }
            }

            if (!isActorNominated)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - startingPointsFromAcademy:f1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {startingPointsFromAcademy:f1}!");
            }
        }
    }
}
