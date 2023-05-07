namespace Assd
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Stats
    {
        private const double STATS_COUNT = 5;

        public const int STAT_MIN_VALUE = 0;
        public const int STAT_MAX_VALUE = 100;

        public Stats(int endurance, int spring, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = spring;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public int Endurance
        {
            get { return endurance; }

            set
            {
                ValidateStat(nameof(this.Endurance), value);

                endurance = value;
            }
        }

        public int Sprint
        {
            get { return sprint; }

            set
            {
                ValidateStat(nameof(this.Sprint), value);

                sprint = value;
            }
        }

        public int Dribble
        {
            get { return dribble; }

            set
            {
                ValidateStat(nameof(this.Dribble), value);

                dribble = value;
            }
        }

        public int Passing
        {
            get { return passing; }

            set
            {
                ValidateStat(nameof(this.Passing), value);

                passing = value;
            }
        }

        public int Shooting
        {
            get { return shooting; }

            set
            {
                ValidateStat(nameof(this.Shooting), value);

                shooting = value;
            }
        }

        public double AverageStat
        {
            get => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / STATS_COUNT;
        }

        private void ValidateStat(string statName, int statValue)
        {
            if (statValue < STAT_MIN_VALUE || statValue > STAT_MAX_VALUE)
            {
                string exceptionMessage = string.Format(GlobalConstans.InvalidStatException,
                    statName, STAT_MIN_VALUE, STAT_MAX_VALUE);

                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
