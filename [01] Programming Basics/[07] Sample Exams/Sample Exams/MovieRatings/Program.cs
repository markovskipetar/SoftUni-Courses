using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());

            string bestMovie = String.Empty;
            double bestMovieRating = 0;

            string worsttMovie = String.Empty;
            double worstMovieRating = double.MaxValue;

            double allMoviesRatings = 0;

            for (int i = 0; i < movies; i++)
            {
                string currentMovie = Console.ReadLine();
                double currentMovieRating = double.Parse(Console.ReadLine());

                if (currentMovieRating > bestMovieRating)
                {
                    bestMovieRating = currentMovieRating;
                    bestMovie = currentMovie;
                }
                else if (currentMovieRating < worstMovieRating)
                {
                    worstMovieRating = currentMovieRating;
                    worsttMovie = currentMovie;
                }

                allMoviesRatings += currentMovieRating;
            }

            double average = allMoviesRatings / movies;

            Console.WriteLine($"{bestMovie} is with highest rating: {bestMovieRating:F1}");
            Console.WriteLine($"{worsttMovie} is with lowest rating: {worstMovieRating:F1}");
            Console.WriteLine($"Average rating: {average:F1}");
        }
    }
}
