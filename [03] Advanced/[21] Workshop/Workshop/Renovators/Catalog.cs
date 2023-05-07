namespace Renovators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;

    public class Catalog
    {
        public Catalog(string name, int neededRenovators, string project)
        {
            this.Renovators = new List<Renovator>();
            this.Name = name;
            this.NeededRenovators = neededRenovators;
            this.Project = project;
        }

        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count => this.Renovators.Count;

        public string AddRenovator(Renovator renovator)
        {
            string message = string.Empty;

            int maxRate = 350;

            if (string.IsNullOrEmpty(renovator.Name) || string.IsNullOrEmpty(renovator.Type))
            {
                message = "Invalid renovator's information.";
            }
            else if (this.NeededRenovators == 0)
            {
                message = "Renovators are no more needed.";
            }
            else if (renovator.Rate > maxRate) //possible >=
            {
                message = "Invalid renovator's rate.";
            }
            else
            {
                this.Renovators.Add(renovator);

                message = $"Successfully added {renovator.Name} to the catalog.";

                if (this.NeededRenovators > 0)
                {
                    this.NeededRenovators--;
                }
            }

            return message;
        }

        public bool RemoveRenovator(string name)
        {
            int removed = this.Renovators.RemoveAll(r => r.Name == name);

            return removed > 0;
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            int removed = this.Renovators.RemoveAll(r => r.Type == type);

            return removed;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = this.Renovators.Find(r => r.Name == name);

            if (renovator is not null)
            {
                renovator.Hired = true;
            }

            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> renovators = this.Renovators.Where(r => r.Days >= days).ToList();

            return renovators;
        }

        public string Report()
        {
            List<Renovator> nonHiredRenovators = this.Renovators.Where(r => r.Hired == false).ToList();

            return $"Renovators available for Project {this.Project}:{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine,nonHiredRenovators)}";
        }
    }
}