namespace TruckTour
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int pumpsCount = int.Parse(Console.ReadLine());

            var pumps = new Queue<int[]>();

            for (int i = 0; i < pumpsCount; i++)
            {
                int[] currentPump = Console.ReadLine().Split().Select(int.Parse).ToArray();

                pumps.Enqueue(currentPump);
            }

            for (int i = 0; i < pumpsCount; i++)
            {
                int tempPetrol = 0;

                bool isPoint = true;

                foreach (var pump in pumps)
                {
                    int petrol = pump[0];
                    int distance = pump[1];

                    tempPetrol += petrol;

                    if (!(tempPetrol >= distance))
                    {
                        isPoint = false;

                        break;
                    }

                    tempPetrol -= distance;
                }

                if (isPoint)
                {
                    Console.WriteLine(i);

                    break;
                }

                pumps.Enqueue(pumps.Dequeue());
            }
        }
    }
}
