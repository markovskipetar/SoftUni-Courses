namespace MOBAChallenger
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> playersPool = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "Season end")
                {
                    break;
                }

                if (input.Length == 3)
                {
                    string player = input[0];
                    string position = input[1];
                    int skill = int.Parse(input[2]);

                    if (!playersPool.ContainsKey(player))
                    {
                        playersPool[player] = new Dictionary<string, int>();
                    }

                    if (!playersPool[player].ContainsKey(position))
                    {
                        playersPool[player][position] = 0;
                    }

                    if (skill > playersPool[player][position])
                    {
                        playersPool[player][position] = skill;
                    }
                }
                else
                {
                    string[] players = input[0].Split(" vs ").ToArray();

                    string firstPlayer = players[0];
                    string secondPlayer = players[1];

                    if (playersPool.ContainsKey(firstPlayer) && playersPool.ContainsKey(secondPlayer))
                    {
                        Dictionary<string, int> firstPlayerPositions = playersPool[firstPlayer];
                        Dictionary<string, int> secondPlayerPositions = playersPool[secondPlayer];

                        foreach (var kvp in firstPlayerPositions)
                        {
                            string positions = kvp.Key;

                            if (secondPlayerPositions.ContainsKey(positions))
                            {
                                int firstPlayerTotalPoints = firstPlayerPositions.Values.Sum();
                                int secondPlayerTotalPoints = secondPlayerPositions.Values.Sum();

                                if (firstPlayerTotalPoints > secondPlayerTotalPoints)
                                {
                                    playersPool.Remove(secondPlayer);
                                }
                                else if (secondPlayerTotalPoints > firstPlayerTotalPoints)
                                {
                                    playersPool.Remove(firstPlayer);
                                }

                                break;
                            }
                        }
                    }
                }
            }

            playersPool = playersPool
                .OrderByDescending(kvp => kvp.Value.Values.Sum())
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);


            foreach (var kvp in playersPool)
            {
                string name = kvp.Key;
                Dictionary<string, int> positions = kvp.Value;

                positions = positions
                    .OrderByDescending(kvp => kvp.Value)
                    .ThenBy(kvp => kvp.Key)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                Console.WriteLine($"{name}: {positions.Values.Sum()} skill");

                foreach (var kvp2 in positions)
                {
                    Console.WriteLine($"- {kvp2.Key} <::> {kvp2.Value}");
                }
            }
        }
    }
}
