using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomLength = int.Parse(Console.ReadLine());
            int roomWidth = int.Parse(Console.ReadLine());
            int roomHeigh = int.Parse(Console.ReadLine());

            int totalSpace = roomLength * roomWidth * roomHeigh;
            int boxesMoved = 0;

            bool isFull = false;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int boxes = int.Parse(input);
                boxesMoved += boxes;

                if (boxesMoved > totalSpace)
                {
                    isFull = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (isFull)
            {
                Console.WriteLine($"No more free space! You need {boxesMoved - totalSpace} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{totalSpace - boxesMoved} Cubic meters left.");
            }
        }
    }
}
