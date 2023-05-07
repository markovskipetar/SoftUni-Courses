namespace SongsQueue
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            var songs = new Queue<string>(input);

            while (songs.Any())
            {
                string commandLine = Console.ReadLine();

                switch (commandLine.Substring(0, 4))
                {
                    case "Play":
                        songs.Dequeue();
                        break;

                    case "Add ":
                        string songToAdd = commandLine.Substring(4);

                        if (!songs.Contains(songToAdd))
                        {
                            songs.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }
                        break;

                    case "Show":
                        Console.WriteLine(String.Join(", ", songs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
