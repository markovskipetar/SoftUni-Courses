using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;

            switch (shape)
            {
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    break;

                case "triangle":
                    double sideLenght = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = (sideLenght * height) / 2;
                    break;

                case "square":
                    double side = double.Parse(Console.ReadLine());
                    area = Math.Pow(side, 2);
                    break;

                case "rectangle":
                    double lenght = double.Parse(Console.ReadLine());
                    double width = double.Parse(Console.ReadLine());
                    area = lenght * width;
                    break;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
