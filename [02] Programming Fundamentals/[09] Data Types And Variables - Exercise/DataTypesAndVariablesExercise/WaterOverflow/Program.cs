using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesAddingWater = int.Parse(Console.ReadLine());

            int tankCapacity = 255;
            int addedQuantity = 0;

            for (int i = 0; i < timesAddingWater; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine());

                if (addedQuantity + currentQuantity <= tankCapacity)
                {
                    addedQuantity += currentQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(addedQuantity);
        }
    }
}
