namespace Assd
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Numerics;

    public class Team
    {
        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name) : this()
        {
            this.Name = name;
        }


        private string name;
        private List<Player> players;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstans.InvalidNameException);
                }

                name = value;
            }
        }

        public int Rating
        {
            get
            {
                int rating = 0;

                if (this.players.Count != 0)
                {
                    rating = (int)(Math.Round(this.players.Sum(s => s.OverallSkill) / players.Count));
                }

                return rating;
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == playerName);

            if (playerToRemove is null)
            {
                string exceptionMessage = string.Format(GlobalConstans.MissingPlayerException,
                    playerName, this.Name);

                throw new ArgumentException(exceptionMessage);
            }

            this.players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.name} - {this.Rating}";
        }
    }
}
