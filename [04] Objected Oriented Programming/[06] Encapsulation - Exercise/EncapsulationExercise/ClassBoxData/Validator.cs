namespace ClassBoxData
{
    using System;

    public class Validator
    {
        public static void ValidateField(string fieldName, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{fieldName} cannot be zero or negative.");
            }
        }
    }
}
