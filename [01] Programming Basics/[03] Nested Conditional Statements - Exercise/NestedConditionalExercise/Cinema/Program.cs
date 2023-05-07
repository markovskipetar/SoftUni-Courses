using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int seats = rows * cols;
            double totalIncome = 0.0;

            if (projection == "Premiere")
            {
                totalIncome = seats * 12;
            }
            else if (projection == "Normal")
            {
                totalIncome = seats * 7.50;
            }
            else if (projection == "Discount")
            {
                totalIncome = seats * 5;
            }

            Console.WriteLine($"{totalIncome:F2} leva");
        }
    }
}
