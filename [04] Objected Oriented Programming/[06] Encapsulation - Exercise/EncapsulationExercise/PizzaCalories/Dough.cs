namespace PizzaCalories
{
    public class Dough : Ingredient
    {
        private const int MinGrams = 1;
        private const int MaxGrams = 200;

        public Dough(string flourType, string bakingTechnique, int weight)
            : base(weight, flourType)
        {
            this.BakingTechnique = bakingTechnique;
        }

        private string bakingTechnique;

        public override string Type
        {
            get => base.Type;

            protected set
            {
                Validator.ValidateFlour(value);

                base.Type = value;
            }
        }

        public string BakingTechnique
        {
            get => bakingTechnique;

            private set
            {
                Validator.ValidateBakingTechnique(value);

                this.bakingTechnique = value;
            }
        }

        public override int Weight
        {
            get => base.Weight;

            protected set
            {
                Validator.ValidateDoughGrams(value, MinGrams, MaxGrams);

                base.Weight = value;
            }
        }

        public double Calories
        {
            get => CalculateCalories();
        }

        private double CalculateCalories()
        {
            double flourModifier = GetFlourModifier();
            double bakingTechniqueModifier = GetBakingTechinqueModifier();

            return base.Weight * base.BaseCaloriesPerGram * flourModifier * bakingTechniqueModifier;
        }

        private double GetFlourModifier()
        {
            switch (base.Type.ToLower())
            {
                case "white":
                    return 1.5;

                case "wholegrain":
                    return 1;

                default:
                    return -1;
            }
        }

        private double GetBakingTechinqueModifier()
        {
            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    return 0.9;

                case "chewy":
                    return 1.1;

                case "homemade":
                    return 1;

                default:
                    return -1;
            }
        }
    }
}
