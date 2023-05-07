using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestMovie = String.Empty;
            int bestMoviePoints = 0;

            int moviesCounter = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "STOP")
                {
                    break;
                }

                moviesCounter++;

                int currentMovieScore = 0;

                for (int i = 0; i < movieName.Length; i++)
                {
                    if ('A' <= movieName[i] && movieName[i] <= 'Z')
                    {
                        currentMovieScore += (movieName[i] - movieName.Length);
                    }
                    else if ('a' <= movieName[i] && movieName[i] <= 'z')
                    {
                        currentMovieScore += (movieName[i] - (2 * movieName.Length));
                    }
                    else
                    {
                        currentMovieScore += movieName[i];
                    }
                }

                if (currentMovieScore > bestMoviePoints)
                {
                    bestMovie = movieName;
                    bestMoviePoints = currentMovieScore;
                }

                if (moviesCounter >= 7)
                {
                    break;
                }
            }

            if (moviesCounter >= 7)
            {
                Console.WriteLine($"The limit is reached.");
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {bestMoviePoints} ASCII sum.");
        }
    }
}
