using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomLenght = double.Parse(Console.ReadLine());
            double roomWidth = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double roomArea = (roomLenght * 100) * (roomWidth * 100);
            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double benchArea = roomArea / 10;

            double freeSpace = roomArea - wardrobeArea - benchArea;

            double spaceForDancers = freeSpace / 7040;

            Console.WriteLine(Math.Floor(spaceForDancers));
        }
    }
}
