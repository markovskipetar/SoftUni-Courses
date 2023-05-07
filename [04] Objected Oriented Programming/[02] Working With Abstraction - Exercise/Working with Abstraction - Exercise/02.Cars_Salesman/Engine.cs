namespace _02.Cars_Salesman
{
    using System.Text;

    public class Engine
    {
        private const string offset = "  ";
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacements = -1;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power, int displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacements = displacement;
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacements = -1;
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacements = displacement;
            this.Efficiency = efficiency;
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacements { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", offset, this.Model);
            sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.Power);
            sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.Displacements == -1 ? "n/a" : this.Displacements.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.Efficiency);

            return sb.ToString();
        }
    }
}
