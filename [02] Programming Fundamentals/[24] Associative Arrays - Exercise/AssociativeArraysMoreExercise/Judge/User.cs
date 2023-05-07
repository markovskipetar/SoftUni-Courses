namespace Judge
{
    public class User
    {
        public User(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

        public string Name { get; set; }
        public int Points { get; set; }
    }
}
