namespace LegendaryFarming
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>();

            legendaryItems["fragments"] = 0;
            legendaryItems["shards"] = 0;
            legendaryItems["motes"] = 0;

            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            string craftedLegendaryItem = String.Empty;

            while (true)
            {
                string[] input = Console.ReadLine().ToLower().Split().ToArray();

                bool isItemCrafted = false;

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (material == "fragments")
                    {
                        legendaryItems[material] += quantity;

                        if (legendaryItems[material] >= 250)
                        {
                            craftedLegendaryItem = "Valanyr"; 

                            legendaryItems[material] -= 250;

                            isItemCrafted = true;
                            break;
                        }
                    }
                    else if (material == "shards")
                    {
                        legendaryItems[material] += quantity;

                        if (legendaryItems[material] >= 250)
                        {
                            craftedLegendaryItem = "Shadowmourne";

                            legendaryItems[material] -= 250;

                            isItemCrafted = true;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        legendaryItems[material] += quantity;

                        if (legendaryItems[material] >= 250)
                        {
                            craftedLegendaryItem = "Dragonwrath";

                            legendaryItems[material] -= 250;

                            isItemCrafted = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(material))
                        {
                            junkItems[material] = 0;
                        }

                        junkItems[material] += quantity;
                    }
                }

                if (isItemCrafted)
                {
                    break;
                }
            }

            Console.WriteLine($"{craftedLegendaryItem} obtained!");

            legendaryItems = legendaryItems
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            junkItems = junkItems
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in legendaryItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in junkItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
