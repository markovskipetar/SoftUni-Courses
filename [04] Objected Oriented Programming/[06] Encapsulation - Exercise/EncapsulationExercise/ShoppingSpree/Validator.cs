namespace ShoppingSpree
{
    using System;

    public class Validator
    {
        public static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
        }

        public static void ValidateMoney(decimal price)
        {
            if (price < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
        }
    }
}
