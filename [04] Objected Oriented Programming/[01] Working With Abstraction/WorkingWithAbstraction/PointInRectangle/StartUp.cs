using System;
using System.Linq;

namespace PointInRectangle
{
    class StartUp
    {
        static void Main()
        {
            int[] rectangleCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rectangle = CreateRectangle(rectangleCoordinates);

            int pointsToCheckCount = int.Parse(Console.ReadLine());

            ReadPoints(pointsToCheckCount, rectangle);
        }

        static Rectangle CreateRectangle(int[] rectangleCoordinates)
        {
            int topLeftX = rectangleCoordinates[0];
            int topLeftY = rectangleCoordinates[1];

            int bottomRightX = rectangleCoordinates[2];
            int bottomRightY = rectangleCoordinates[3];

            Rectangle rectangle = new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY);

            return rectangle;
        }

        static void ReadPoints(int pointsToCheckCount, Rectangle rectangle)
        {
            for (int i = 0; i < pointsToCheckCount; i++)
            {
                int[] currentPointCoordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int pointX = currentPointCoordinates[0];
                int pointY = currentPointCoordinates[1];

                Point point = new Point(pointX, pointY);

                CheckIfPointIsInside(point, rectangle);
            }
        }

        static void CheckIfPointIsInside(Point point, Rectangle rectangle)
        {
            bool isInside = rectangle.IsPointInside(point);

            Console.WriteLine(isInside);
        }
    }
}
