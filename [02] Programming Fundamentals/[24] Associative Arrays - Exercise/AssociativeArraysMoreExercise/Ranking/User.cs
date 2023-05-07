namespace Ranking
{
    using System.Linq;
    using System.Collections.Generic;

    public class User
    {
        public User()
        {
            this.Contests = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Contests { get; set; }
        public int TotalPoints { get; set; }

        public void GetTotalPoints()
        {
            foreach (var kvp in this.Contests)
            {
                TotalPoints += kvp.Value;
            }
        }

        public void Sort()
        {
            this.Contests = Contests
                .OrderByDescending(kvp => kvp.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }
    }
}
