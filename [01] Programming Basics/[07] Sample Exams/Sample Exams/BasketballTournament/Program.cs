using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchesWon = 0;
            int matchesLost = 0;

            while (true)
            {
                string tournamentName = Console.ReadLine();

                if (tournamentName == "End of tournaments")
                {
                    break;
                }

                int currentTournamentMatches = int.Parse(Console.ReadLine());

                for (int i = 0; i < currentTournamentMatches; i++)
                {
                    int ourTeamPoints = int.Parse(Console.ReadLine());
                    int enemyTeamPoints = int.Parse(Console.ReadLine());

                    if (ourTeamPoints > enemyTeamPoints)
                    {
                        int difference = ourTeamPoints - enemyTeamPoints;
                        matchesWon++;

                        Console.WriteLine($"Game {i + 1} of tournament {tournamentName}: win with {difference} points.");
                    }
                    else
                    {
                        int difference = enemyTeamPoints - ourTeamPoints;
                        matchesLost++;

                        Console.WriteLine($"Game {i + 1} of tournament {tournamentName}: lost with {difference} points.");
                    }
                }
            }

            double totalMatches = matchesWon + matchesLost;

            double percentWon = (matchesWon / totalMatches) * 100;
            double percentLost = (matchesLost / totalMatches) * 100;

            Console.WriteLine($"{percentWon:F2}% matches win");
            Console.WriteLine($"{percentLost:F2}% matches lost");
        }
    }
}
