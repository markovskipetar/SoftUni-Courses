using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangleBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isOnTopSide = y == y1 && (x1 <= x && x <= x2);
            bool isOnBottomSide = y == y2 && (x1 <= x && x <= x2);
            bool isOnRightSide = x == x1 && (y1 <= y && y <= y2);
            bool isOnLeftSide = x == x2 && (y1 <= y && y <= y2);

            if (isOnTopSide || isOnBottomSide || isOnRightSide || isOnLeftSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
