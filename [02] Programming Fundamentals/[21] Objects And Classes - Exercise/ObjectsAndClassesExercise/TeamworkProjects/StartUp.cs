namespace TeamworkProjects
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();
            List<string> teamNames = new List<string>();
            List<string> creators = new List<string>();
            List<string> members = new List<string>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                CreateTeam(creators, teamNames, teams, members);
            }

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end of assignment")
                {
                    break;
                }

                AddUser(members, teamNames, teams, inputLine);
            }

            List<string> teamsToDisband = new List<string>();
            GetTeamsToDisband(teams, teamsToDisband);

            PrintTeams(teams, teamsToDisband);
        }

        static void GetTeamsToDisband(List<Team> teams, List<string> teamsToDisband)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Members.Count == 0)
                {
                    teamsToDisband.Add(teams[i].Name);

                    teams.RemoveAt(i);

                    i--;
                }
            }
        }

        static void PrintTeams(List<Team> teams, List<string> teamsToDisband)
        {
            teams = teams.OrderByDescending(team => team.Members.Count)
               .ThenBy(team => team.Name)
               .ToList();

            teamsToDisband.Sort();

            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");

            foreach (var teamToDisband in teamsToDisband)
            {
                Console.WriteLine(teamToDisband);
            }
        }

        static void AddUser(List<string> members, List<string> teamNames, List<Team> teams, string inputLine)
        {
            string[] userInfo = inputLine.Split("->").ToArray();

            string userName = userInfo[0];
            string teamName = userInfo[1];

            if (!teamNames.Contains(teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
            }
            else if (members.Contains(userName))
            {
                Console.WriteLine($"Member {userName} cannot join team {teamName}!");
            }
            else
            {
                Team currentTeam = GetTeamByName(teams, teamName);
                currentTeam.Members.Add(userName);
            }
        }

        static Team GetTeamByName(List<Team> teams, string teamName)
        {
            Team teamToReturn = new Team();

            foreach (var team in teams)
            {
                if (team.Name == teamName)
                {
                    teamToReturn = team;
                    break;
                }
            }

            return teamToReturn;
        }

        static void CreateTeam(List<string> creators, List<string> teamNames, List<Team> teams, List<string> members)
        {
            string[] input = Console.ReadLine().Split("-").ToArray();

            string creator = input[0];
            string teamName = input[1];

            if (teamNames.Contains(teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
            }
            else if (creators.Contains(creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }
            else
            {
                Team currentTeam = new Team(teamName, creator);

                teams.Add(currentTeam);
                creators.Add(creator);
                teamNames.Add(teamName);
                members.Add(creator);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }
    }

    public class Team
    {
        public Team()
        {

        }

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            this.Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            this.Members = this.Members.OrderBy(member => member).ToList();

            string membersAsText = string.Empty;

            for (int i = 0; i < this.Members.Count; i++)
            {
                if (i == this.Members.Count - 1)
                {
                    membersAsText += $"-- {this.Members[i]}";
                }
                else
                {
                    membersAsText += $"-- {this.Members[i]}{Environment.NewLine}";
                }
            }

            return $"{this.Name}{Environment.NewLine}- {this.Creator}{Environment.NewLine}{membersAsText}";
        }
    }
}
