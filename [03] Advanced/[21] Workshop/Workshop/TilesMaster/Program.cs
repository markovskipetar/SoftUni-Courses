using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;

namespace TilesMaster
{
    internal class Program
    {
        static void Main()
        {
            List<int> whiteTilesInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> whiteTiles = new Stack<int>(whiteTilesInput);

            int[] grayTilesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> greyTiles = new Queue<int>(grayTilesInput);

            Dictionary<string, int> locationTiles = new Dictionary<string, int>();

            while (true)
            {
                if (whiteTiles.Count == 0 || greyTiles.Count == 0)
                {
                    break;
                }

                int whiteTile = whiteTiles.Pop();
                int greyTile = greyTiles.Dequeue();

                int newTileSize = whiteTile + greyTile;

                if (whiteTile == greyTile)
                {
                    string location = GetLocation(newTileSize);

                    if (!locationTiles.ContainsKey(location))
                    {
                        locationTiles[location] = 0;
                    }

                    locationTiles[location]++;
                }
                else
                {
                    int halfWhiteTile = whiteTile / 2;

                    whiteTiles.Push(halfWhiteTile);
                    greyTiles.Enqueue(greyTile);
                }
            }

            locationTiles = locationTiles
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            string whiteTilesMessage = "none";

            if (whiteTiles.Count >= 1)
            {
                whiteTilesMessage = string.Join(", ", whiteTiles);
            }

            string greyTilesMessage = "none";

            if (greyTiles.Count >= 1)
            {
                greyTilesMessage = string.Join(", ", greyTiles);
            }

            Console.WriteLine($"White tiles left: {whiteTilesMessage}");
            Console.WriteLine($"Grey tiles left: {greyTilesMessage}");

            foreach (var kvp in locationTiles)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        static string GetLocation(int newTileSize)
        {
            string location = "";

            switch (newTileSize)
            {
                case 40:
                    location = "Sink";
                    break;
                case 50:
                    location = "Oven";
                    break;
                case 60:
                    location = "Countertop";
                    break;
                case 70:
                    location = "Wall";
                    break;
                default:
                    location = "Floor";
                    break;
            }

            return location;
        }
    }
}
