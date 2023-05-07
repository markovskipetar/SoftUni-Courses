using System;

namespace Renovators
{
    public class Renovator
    {
        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
            this.Hired = false;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }
        public bool Hired { get; set; }

        public override string ToString()
        {
            return $"-Renovator: {this.Name}{Environment.NewLine}" +
                $"--Specialty: {this.Type}{Environment.NewLine}" +
                $"--Rate per day: {this.Rate} BGN";
        }
    }
}
