namespace FashionBoutique
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            var clothes = new Stack<int>(input);
            int racksUsed = 1;
            int tempClothesValues = 0;

            while (clothes.Any())
            {
                int cloth = clothes.Peek();
                if (cloth + tempClothesValues > rackCapacity)
                {
                    racksUsed++;
                    tempClothesValues = 0;
                }

                tempClothesValues += clothes.Pop();
            }

            Console.WriteLine(racksUsed);
        }
    }
}
