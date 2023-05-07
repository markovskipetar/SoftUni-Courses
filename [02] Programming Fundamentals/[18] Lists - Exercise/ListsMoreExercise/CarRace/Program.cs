namespace CarRace
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> times = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            double firstRacerTime = GetFirstRacerTime(times);
            double secondRacerTime = GetSecondRacerTime(times);

            PrintWinner(firstRacerTime, secondRacerTime);
        }

        static void PrintWinner(double firstRacerTime, double secondRacerTime)
        {
            double winnerTime = 0;
            string winner = String.Empty;

            if (firstRacerTime < secondRacerTime)
            {
                winnerTime = firstRacerTime;
                winner = "left";
            }
            else
            {
                winnerTime = secondRacerTime;
                winner = "right";
            }

            Console.WriteLine($"The winner is {winner} with total time: {winnerTime}");
        }

        static double GetSecondRacerTime(List<int> times)
        {
            int midElement = times.Count / 2;

            double currentTotalTime = 0;

            for (int i = times.Count - 1; i > midElement; i--)
            {
                double currentTime = times[i];

                if (currentTime == 0)
                {
                    currentTotalTime *= 0.8;
                }
                else
                {
                    currentTotalTime += currentTime;
                }
            }

            return currentTotalTime;
        }

        static double GetFirstRacerTime(List<int> times)
        {
            int midElement = times.Count / 2;

            double currentTotalTime = 0;

            for (int i = 0; i < midElement; i++)
            {
                double currentTime = times[i];

                if (currentTime == 0)
                {
                    currentTotalTime *= 0.8;
                }
                else
                {
                    currentTotalTime += currentTime;
                }
            }

            return currentTotalTime;
        }
    }
}
