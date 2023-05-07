namespace FootballTeamGenerator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Player
    {
        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        private string name;
        private Stats stats;

        public string Name
        {
            get { return name; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstans.InvalidNameException);
                }

                name = value;
            }
        }

        public Stats Stats
        {
            get { return stats; }
            private set { stats = value; }
        }

        public double OverallSkill
        {
            get => this.stats.AverageStat;
        }
    }
}
