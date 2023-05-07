namespace Wardrobe
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] clothesInfo = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = clothesInfo[0];
                string[] clothes = clothesInfo[1].Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int j = 0; j < clothes.Length; j++)
                {
                    string currentCloth = clothes[j];

                    if (!wardrobe[color].ContainsKey(currentCloth))
                    {
                        wardrobe[color][currentCloth] = 0;
                    }

                    wardrobe[color][currentCloth]++;
                }
            }

            string[] searchedItem = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string searchedColor = searchedItem[0];
            string searchedCloth = searchedItem[1];

            foreach (var (color, dict) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");

                foreach (var cloth in dict)
                {
                    if (color == searchedColor && cloth.Key == searchedCloth)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!) ");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
