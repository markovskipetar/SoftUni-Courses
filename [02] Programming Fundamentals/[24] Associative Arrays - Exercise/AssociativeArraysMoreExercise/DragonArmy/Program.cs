namespace DragonArmy
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int numberOfDragons = int.Parse(Console.ReadLine());

            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string type = input[0];
                string name = input[1];
                int damage = input[2] == "null" ? 45 : int.Parse(input[2]);
                int health = input[3] == "null" ? 250 : int.Parse(input[3]);
                int armor = input[4] == "null" ? 10 : int.Parse(input[4]);

                Dragon currentDragon = new Dragon(type, name, damage, health, armor);

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new List<Dragon>();
                    dragons[type].Add(currentDragon);
                }
                else
                {
                    bool isContaining = false;
                    Dragon dragon = new Dragon(); ;

                    foreach (var curDragon in dragons[type])
                    {
                        if (curDragon.Name == name)
                        {
                            isContaining = true;
                            dragon = curDragon;
                            break;
                        }
                    }

                    if (isContaining)
                    {
                        dragon.Damage = damage;
                        dragon.Armor = armor;
                        dragon.Health = health;
                    }
                    else
                    {
                        dragons[type].Add(currentDragon);
                    }
                }
            }

            foreach (var kvp in dragons)
            {
                List<Dragon> list = kvp.Value;
                list = list.OrderBy(x => x.Name).ToList();

                double avgArmor = list.Average(x => x.Armor);
                double avgHealth = list.Average(x => x.Health);
                double avgDamaga = list.Average(x => x.Damage);

                Console.WriteLine($"{kvp.Key}::({avgDamaga:f2}/{avgHealth:f2}/{avgArmor:F2})");

                foreach (var item in list)
                {
                    Console.WriteLine($"-{item.Name} -> damage: {item.Damage}, health: {item.Health}, armor: {item.Armor}");
                }
            }
        }
    }
}
