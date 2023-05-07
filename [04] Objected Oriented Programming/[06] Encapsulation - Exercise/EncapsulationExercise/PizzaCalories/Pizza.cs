namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private const int MinLength = 1;
        private const int MaxLength = 15;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public string Name
        {
            get => this.name;

            private set
            {
                Validator.ValidatePizzaName(value, MinLength, MaxLength);

                this.name = value;
            }
        }

        public void AddDough(Dough dough)
        {
            this.dough = dough;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            double totalCalories = GetTotalCalories();

            return $"{this.name} - {totalCalories:f2} Calories.";
        }

        private double GetTotalCalories()
        {
            double toppingsCalories = this.toppings.Sum(t => t.Calories);

            return toppingsCalories + this.dough.Calories;
        }
    }
}
