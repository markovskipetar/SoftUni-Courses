namespace ExtractPersonInformation
{
    using System;

    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();

                int atIndex = input.IndexOf('@');
                int pipeIndex = input.IndexOf('|');

                int nameLength = pipeIndex - atIndex - 1;
                int nameStartIndex = atIndex + 1;

                string name = input.Substring(nameStartIndex, nameLength);

                int hashIndex = input.IndexOf('#');
                int asteriskIndex = input.IndexOf('*');

                int ageAsTextLength = asteriskIndex - hashIndex - 1;
                int ageAsTextStartIndex = hashIndex + 1;

                int age = int.Parse(input.Substring(ageAsTextStartIndex, ageAsTextLength));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
