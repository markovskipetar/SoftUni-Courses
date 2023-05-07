namespace DrumSet
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            List<int> drumSetCopy = new List<int>(drumSet);

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "Hit it again, Gabsy!")
                {
                    break;
                }

                int hitPower = int.Parse(inputLine);

                savings = DecreaseDrumsQuality(hitPower, drumSet, drumSetCopy, savings);
            }

            Console.WriteLine(String.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }

        static double DecreaseDrumsQuality(int hitPower, List<int> drumSet, List<int> drumSetCopy, double savings)
        {
            for (int i = 0; i < drumSet.Count; i++)
            {
                drumSet[i] -= hitPower;

                int drumQuality = drumSet[i];

                if (drumQuality <= 0)
                {
                    int drumInitialQuality = drumSetCopy[i];

                    double drumPrice = drumInitialQuality * 3;

                    if (savings >= drumPrice)
                    {
                        drumSet[i] = drumInitialQuality;

                        savings -= drumPrice;
                    }
                    else
                    {
                        drumSet.RemoveAt(i);
                        drumSetCopy.RemoveAt(i);

                        i--;
                    }
                }
            }

            return savings;
        }
    }
}
