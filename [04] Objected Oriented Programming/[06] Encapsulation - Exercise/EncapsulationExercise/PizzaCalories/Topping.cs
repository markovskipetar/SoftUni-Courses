namespace PizzaCalories
{
    public class Topping : Ingredient
    {
        private const int MinGrams = 1;
        private const int MaxGrams = 50;

        public Topping(string type, int weight)
            : base(weight, type)
        {
        }

        public override string Type
        {
            get => base.Type;

            protected set
            {
                Validator.ValidateTopping(value);

                base.Type = value;
            }
        }

        public override int Weight
        {
            get => base.Weight;

            protected set
            {
                Validator.ValidateToppingGrams(value, MinGrams, MaxGrams, base.Type);

                base.Weight = value;
            }
        }

        public double Calories
        {
            get => CalculateCalories();
        }

        private double CalculateCalories()
        {
            double toppingTypeModifier = GetToppingTypeModifier();

            double totalCalories = base.Weight * base.BaseCaloriesPerGram * toppingTypeModifier;

            return totalCalories;
        }

        private double GetToppingTypeModifier()
        {
            switch (base.Type.ToLower())
            {
                case "meat":
                    return 1.2;

                case "veggies":
                    return 0.8;

                case "cheese":
                    return 1.1;

                case "sauce":
                    return 0.9;

                default:
                    return -1;
            }
        }
    }
}
