using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakePieces = cakeLenght * cakeWidth;

            int pieces = 0;
            bool isCakeOver = false;

            string command = Console.ReadLine();

            while (command != "STOP")
            {
                pieces += int.Parse(command);

                if (pieces > cakePieces)
                {
                    isCakeOver = true;
                    break;
                }
                else if (pieces == cakePieces)
                {
                    break;
                }

                command = Console.ReadLine();
            }

            if (isCakeOver)
            {
                Console.WriteLine($"No more cake left! You need {pieces - cakePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakePieces - pieces} pieces are left.");
            }
        }
    }
}
