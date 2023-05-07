using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            int libraryCapacity = int.Parse(Console.ReadLine());

            int checkedBooks = 0;
            bool isBookFound = false;

            while (checkedBooks < libraryCapacity)
            {
                string currentBook = Console.ReadLine();

                if (currentBook == wantedBook)
                {
                    isBookFound = true;
                    break;
                }

                checkedBooks++;
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}
