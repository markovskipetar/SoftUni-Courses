using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (true)
            {
                string currentMovie = Console.ReadLine();

                if (currentMovie == "Finish")
                {
                    break;
                }

                int currentMovieSeatsAvailable = int.Parse(Console.ReadLine());
                double currentMovieSeatsTaken = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;

                        case "standard":
                            standardTickets++;
                            break;

                        case "kid":
                            kidTickets++;
                            break;
                    }

                    currentMovieSeatsTaken++;

                    if (currentMovieSeatsTaken >= currentMovieSeatsAvailable)
                    {
                        break;
                    }
                }

                double percentTaken = (currentMovieSeatsTaken / currentMovieSeatsAvailable) * 100;

                Console.WriteLine($"{currentMovie} - {percentTaken}% full.");
            }

            double totalTickets = studentTickets + standardTickets + kidTickets;

            double percentStudentTickets = (studentTickets / totalTickets) * 100;
            double percentStandardTickets = (standardTickets / totalTickets) * 100;
            double kidTicketsTickets = (kidTickets / totalTickets) * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{percentStudentTickets:F2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{kidTicketsTickets:F2}% kids tickets.");
        }
    }
}
