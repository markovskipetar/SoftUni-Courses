namespace _05.Greedy_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static long bagCapacity;
        private static Dictionary<string, Dictionary<string, long>> bag;

        private static long gold;
        private static long stones;
        private static long money;
        static string GetItemType(string name, long quantity)
        {
            string itemType = string.Empty;

            if (name.Length == 3)
            {
                itemType = "Cash";
            }
            else if (name.ToLower().EndsWith("gem"))
            {
                itemType = "Gem";
            }
            else if (name.ToLower() == "gold")
            {
                itemType = "Gold";
            }

            if (itemType == "")
            {
                itemType = null;
            }
            else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + quantity)
            {
                itemType = null;
            }

            return itemType;
        }
        static void AddItemToBag(string itemType, string name, long quantity)
        {
            if (!bag.ContainsKey(itemType))
            {
                bag[itemType] = new Dictionary<string, long>();
            }

            if (!bag[itemType].ContainsKey(name))
            {
                bag[itemType][name] = 0;
            }

            bag[itemType][name] += quantity;
            if (itemType == "Gold")
            {
                gold += quantity;
            }
            else if (itemType == "Gem")
            {
                stones += quantity;
            }
            else if (itemType == "Cash")
            {
                money += quantity;
            }
        }
        static void PrintItemsInfo()
        {
            foreach (var item in bag)
            {
                Console.WriteLine($"<{item.Key}> ${item.Value.Values.Sum()}");
                foreach (var item2 in item.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            bagCapacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bag = new Dictionary<string, Dictionary<string, long>>();
            gold = 0;
            stones = 0;
            money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long quantity = long.Parse(safe[i + 1]);

                string itemType = GetItemType(name, quantity);

                if (itemType == null)
                {
                    continue;
                }

                switch (itemType)
                {
                    case "Gem":
                        if (!bag.ContainsKey(itemType))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (quantity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[itemType].Values.Sum() + quantity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(itemType))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (quantity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[itemType].Values.Sum() + quantity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                AddItemToBag(itemType, name, quantity);
            }

            PrintItemsInfo();
        }
    }

}
