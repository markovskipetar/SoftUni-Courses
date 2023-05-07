using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double rectangleLength = Math.Abs(x1 - x2);
            double rectangleWidth = Math.Abs(y1 - y2);

            double rectangleArea = rectangleLength * rectangleWidth;
            double rectanglePerimeter = 2 * (rectangleLength + rectangleWidth);

            Console.WriteLine($"{rectangleArea:F2}");
            Console.WriteLine($"{rectanglePerimeter:F2}");
        }
    }
}
