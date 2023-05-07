namespace Snowwhite
{
    public class Dwarf
    {
        public Dwarf(string hatColor, int physics, string name)
        {
            this.HatColor = hatColor;
            this.Physics = physics;
            this.Name = name;
        }

        public string HatColor { get; private set; }
        public string Name { get; private set; }
        public int Physics { get; set; }
    }
}
