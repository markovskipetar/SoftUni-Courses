using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double closestDistance = double.MaxValue;

            double bestX = 0;
            double bestY = 0;

            for (int i = 0; i < 2; i++)
            {
                double coordinateX = double.Parse(Console.ReadLine());
                double coordinateY = double.Parse(Console.ReadLine());

                double currentDistnace = FindDistanceBetweenTwoPoints(coordinateX, coordinateY);

                if (currentDistnace < closestDistance)
                {
                    bestX = coordinateX;
                    bestY = coordinateY;

                    closestDistance = currentDistnace;
                }
            }

            Console.WriteLine($"({bestX}, {bestY})");
        }

        static double FindDistanceBetweenTwoPoints(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));

            return distance;
        }
    }
}
