namespace FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Engine
    {
        public Engine()
        {
            teams = new List<Team>();
        }

        private List<Team> teams;

        public void Run()
        {
            while (true)
            {
                string[] input = Console.ReadLine()
                .Split(';', StringSplitOptions.None)
                .ToArray();

                string command = input[0];

                if (command == "END")
                {
                    break;
                }

                string teamName = input[1];

                try
                {
                    if (command == "Team")
                    {
                        AddNewTeam(teamName);
                    }
                    else if (command == "Add")
                    {
                        string playerName = input[2];

                        Stats stats = CreateStats(input.Skip(3).Select(int.Parse).ToArray());
                        Player player = new Player(playerName, stats);

                        AddPlayerToTeam(player, teamName);
                    }
                    else if (command == "Remove")
                    {
                        string playerName = input[2];

                        RemovePlayerFromTeam(teamName, playerName);
                    }
                    else if (command == "Rating")
                    {
                        ShowRating(teamName);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void AddNewTeam(string teamName)
        {
            Team team = new Team(teamName);

            this.teams.Add(team);
        }

        private void AddPlayerToTeam(Player player, string teamName)
        {
            ValidateTeam(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            team.AddPlayer(player);
        }

        private void RemovePlayerFromTeam(string teamName, string playerName)
        {
            ValidateTeam(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            team.RemovePlayer(playerName);
        }

        private void ShowRating(string teamName)
        {
            ValidateTeam(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            Console.WriteLine(team);
        }

        private Stats CreateStats(int[] inputStats)
        {
            Stats stats = new Stats(inputStats[0], inputStats[1], inputStats[2], inputStats[3], inputStats[4]);

            return stats;
        }

        private void ValidateTeam(string teamName)
        {
            if (!this.teams.Any(t => t.Name == teamName))
            {
                string exceptionMessage = string.Format(GlobalConstans.MissingTeamException,
                    teamName);

                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
