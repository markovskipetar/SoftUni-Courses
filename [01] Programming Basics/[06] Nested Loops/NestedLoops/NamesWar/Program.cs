using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesWar
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string winner = String.Empty;
            int winnerScore = 0;

            while (name != "STOP")
            {
                int currentNameSum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    currentNameSum += name[i];
                }

                if (currentNameSum > winnerScore)
                {
                    winnerScore = currentNameSum;
                    winner = name;
                }

                name = Console.ReadLine();
            }

            Console.WriteLine($"Winner is {winner} – {winnerScore}!");
        }
    }
}
