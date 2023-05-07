namespace PizzaCalories
{
    using System;

    public class Validator
    {
        public static void ValidateFlour(string flourType)
        {
            flourType = flourType.ToLower();

            if (flourType != "white" && flourType != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }

        public static void ValidateBakingTechnique(string bakingTechnique)
        {
            bakingTechnique = bakingTechnique.ToLower();

            if (bakingTechnique != "crispy" && bakingTechnique != "chewy" && bakingTechnique != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }

        public static void ValidateDoughGrams(int grams, int minGrams, int maxGrams)
        {
            if (grams < minGrams || grams > maxGrams)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
        }

        public static void ValidateToppingGrams(int grams, int minGrams, int maxGrams, string topping)
        {
            if (grams < minGrams || grams > maxGrams)
            {
                throw new ArgumentException($"{topping} weight should be in the range [1..50].");
            }
        }

        public static void ValidateTopping(string topping)
        {
            string toppingCopy = topping;
            topping = topping.ToLower();

            if (topping != "meat" && topping != "veggies" && topping != "cheese" && topping != "sauce")
            {
                throw new ArgumentException($"Cannot place {toppingCopy} on top of your pizza.");
            }
        }

        public static void ValidatePizzaName(string name, int minLenght, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < minLenght || name.Length > maxLength)
            {
                throw new ArgumentException($"Pizza name should be between {minLenght} and {maxLength} symbols.");
            }
        }
    }
}