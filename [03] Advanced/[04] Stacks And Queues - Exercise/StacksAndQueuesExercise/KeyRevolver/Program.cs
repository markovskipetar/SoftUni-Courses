namespace KeyRevolver
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] LocksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligencePrice = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(bulletsInput);
            var locks = new Queue<int>(LocksInput);
            int usedBullets = 0;

            while (bullets.Any() && locks.Any())
            {
                int currentLock = locks.Peek();
                int bullet = bullets.Pop();
                usedBullets++;

                if (bullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bullets.Count > 0 && usedBullets % gunBarrelSize == 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Any())
            {
                int locksLeft = locks.Count;

                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }
            else
            {
                int bulletsLeft = bullets.Count;
                int moneySpent = usedBullets * bulletPrice;
                int moneyEarned = intelligencePrice - moneySpent;

                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
