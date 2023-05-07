using System;
using System.Linq;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];

            if (fieldSize == 0)
            {
                return;
            }

            for (int i = 0; i < bugsIndexes.Length; i++)
            {
                int currentIndex = bugsIndexes[i];

                if (0 <= currentIndex && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "end")
                {
                    break;
                }

                int startIndex = int.Parse(input[0]);
                string direction = input[1];
                int flyLength = int.Parse(input[2]);

                if (!(0 <= startIndex && startIndex < field.Length))
                {
                    continue;
                }

                if (field[startIndex] == 0)
                {
                    continue;
                }

                if (direction == "left")
                {
                    flyLength = -flyLength;
                }

                int indexAfterFly = startIndex + flyLength;

                while (true)
                {
                    field[startIndex] = 0;

                    if (indexAfterFly < 0 || indexAfterFly >= fieldSize)
                    {
                        break;
                    }

                    if (field[indexAfterFly] == 0)
                    {
                        field[indexAfterFly] = 1;
                        break;
                    }

                    indexAfterFly += flyLength;
                }
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
