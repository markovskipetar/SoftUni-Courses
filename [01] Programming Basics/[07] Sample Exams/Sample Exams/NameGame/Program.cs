using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string winnerName = String.Empty;
            int winnerPoints = 0;

            while (true)
            {
                string playerName = Console.ReadLine();

                if (playerName == "Stop")
                {
                    break;
                }

                int lettersCount = playerName.Length;

                int currentPlayerPoints = 0;

                for (int i = 0; i < lettersCount; i++)
                {
                    int currentLetterNumber = int.Parse(Console.ReadLine());
                    char currentLetter = playerName[i];

                    if (currentLetterNumber == currentLetter)
                    {
                        currentPlayerPoints += 10;
                    }
                    else
                    {
                        currentPlayerPoints += 2;
                    }
                }

                if (currentPlayerPoints >= winnerPoints)
                {
                    winnerName = playerName;
                    winnerPoints = currentPlayerPoints;
                }
            }

            Console.WriteLine($"The winner is {winnerName} with {winnerPoints} points!");
        }
    }
}
