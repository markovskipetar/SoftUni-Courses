namespace PokemonDontGo
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            List<int> distancesToPokemons = Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToList();

            int sum = 0;

            while (true)
            {
                int index = int.Parse(Console.ReadLine());

                int element = 0;

                if (index < 0)
                {
                    int firstElement = distancesToPokemons[0];
                    int lastElement = distancesToPokemons[distancesToPokemons.Count - 1];

                    element = firstElement;

                    distancesToPokemons[0] = lastElement;
                }
                else if (index >= distancesToPokemons.Count)
                {
                    int firstElement = distancesToPokemons[0];
                    int lastElement = distancesToPokemons[distancesToPokemons.Count - 1];

                    element = lastElement;

                    distancesToPokemons[distancesToPokemons.Count - 1] = firstElement;

                }
                else
                {
                    element = distancesToPokemons[index];
                    distancesToPokemons.RemoveAt(index);
                }

                sum += element;

                if (distancesToPokemons.Count == 0)
                {
                    break;
                }

                MakeChanges(distancesToPokemons, element);
            }

            Console.WriteLine(sum);
        }

        static void MakeChanges(List<int> distancesToPokemons, int element)
        {
            for (int i = 0; i < distancesToPokemons.Count; i++)
            {
                if (distancesToPokemons[i] <= element)
                {
                    distancesToPokemons[i] += element;
                }
                else
                {
                    distancesToPokemons[i] -= element;
                }
            }
        }
    }
}
