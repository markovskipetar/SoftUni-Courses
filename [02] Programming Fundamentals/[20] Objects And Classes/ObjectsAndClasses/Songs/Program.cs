namespace Songs
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] songData = Console.ReadLine()
                    .Split('_')
                    .ToArray();

                string typeList = songData[0];
                string name = songData[1];
                string time = songData[2];

                Song currentSong = new Song(typeList, name, time);

                songs.Add(currentSong);
            }

            string typeListToPrint = Console.ReadLine();

            foreach (var song in songs)
            {
                string songTypeList = song.TypeList;

                if (songTypeList == typeListToPrint || typeListToPrint == "all")
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}