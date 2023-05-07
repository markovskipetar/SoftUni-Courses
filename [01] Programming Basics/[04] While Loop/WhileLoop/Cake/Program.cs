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
            int cakeLength = int.Parse(Console.ReadLine());

            int cakePieces = cakeLength * cakeWidth;
            int guestsPiecesCount = 0;

            bool cakeIsOver = false;

            string currentGuestPieces = Console.ReadLine();

            while (currentGuestPieces != "STOP")
            {
                guestsPiecesCount += int.Parse(currentGuestPieces);

                if (guestsPiecesCount > cakePieces)
                {
                    cakeIsOver = true;
                    break;
                }
                else if (guestsPiecesCount == cakePieces)
                {
                    break;
                }

                currentGuestPieces = Console.ReadLine();
            }

            if (cakeIsOver)
            {
                Console.WriteLine($"No more cake left! You need {guestsPiecesCount - cakePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{cakePieces - guestsPiecesCount} pieces are left.");
            }
        }
    }
}
