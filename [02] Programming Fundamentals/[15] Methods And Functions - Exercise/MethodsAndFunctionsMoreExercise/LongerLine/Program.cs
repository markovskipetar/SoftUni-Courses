using System;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double longestLine = double.MinValue;

            double firstPointX = 0;
            double firstPointY = 0;

            double secondPointX = 0;
            double secondPointY = 0;

            for (int i = 0; i < 2; i++)
            {
                double currentFirstPointX = double.Parse(Console.ReadLine());
                double currentFirstPointY = double.Parse(Console.ReadLine());

                double currentSecondPointX = double.Parse(Console.ReadLine());
                double currentSecondPointY = double.Parse(Console.ReadLine());

                double currentLineLength = FindDistanceBetweenTwoPoints(currentFirstPointX, currentFirstPointY, currentSecondPointX, currentSecondPointY);

                if (currentLineLength > longestLine)
                {
                    longestLine = currentLineLength;

                    double firstPointDistanceToZero = FindDistanceBetweenTwoPoints(0, 0, currentFirstPointX, currentFirstPointY);
                    double secondPointDistanceToZero = FindDistanceBetweenTwoPoints(0, 0, currentSecondPointX, currentSecondPointY);

                    if (firstPointDistanceToZero <= secondPointDistanceToZero)
                    {
                        firstPointX = currentFirstPointX;
                        firstPointY = currentFirstPointY;

                        secondPointX = currentSecondPointX;
                        secondPointY = currentSecondPointY;
                    }
                    else
                    {
                        firstPointX = currentSecondPointX;
                        firstPointY = currentSecondPointY;

                        secondPointX = currentFirstPointX;
                        secondPointY = currentFirstPointY;
                    }
                }
            }

            Console.WriteLine($"({firstPointX}, {firstPointY})({secondPointX}, {secondPointY})");
        }

        static double FindDistanceBetweenTwoPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            return distance;
        }
    }
}
