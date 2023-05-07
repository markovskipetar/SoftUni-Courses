namespace PizzaCalories
{
    public abstract class Ingredient
    {
        public Ingredient(int weight, string type)
        {
            this.Type = type;
            this.Weight = weight;
        }

        private string type;
        private int weight;

        public virtual string Type
        {
            get => this.type;

            protected set
            {
                this.type = value;
            }
        }

        public virtual int Weight
        {
            get => weight;

            protected set
            {
                this.weight = value;
            }
        }

        public int BaseCaloriesPerGram { get => 2; }
    }
}
