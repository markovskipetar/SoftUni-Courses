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
            string movieName = Console.ReadLine();

            double kidTickets = 0;
            double studentTickets = 0;
            double standardTickets = 0;

            while (movieName != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                double currentMovieUsedSeats = 0;

                bool isFull = false;

                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    if (ticketType == "kid")
                    {
                        kidTickets++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }

                    currentMovieUsedSeats++;

                    if (currentMovieUsedSeats >= freeSeats)
                    {
                        isFull = true;
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                if (isFull)
                {
                    Console.WriteLine($"{movieName} - 100.00% full.");
                }
                else
                {
                    double percent = currentMovieUsedSeats / freeSeats * 100;
                    Console.WriteLine($"{movieName} - {percent:f2}% full.");
                }

                movieName = Console.ReadLine();
            }

            double totalTickets = kidTickets + standardTickets + studentTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTickets / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardTickets / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidTickets / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
