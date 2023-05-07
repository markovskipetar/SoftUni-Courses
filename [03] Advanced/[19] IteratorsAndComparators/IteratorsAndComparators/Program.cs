namespace IteratorsAndComparators
{
    using System;
    internal class Program
    {
        static void Main()
        {
            Book book = new Book("Baba yaga", 2004, "Angel");
            Book book2 = new Book("Baba yaga2", 2005, "Gosho");
            Book book3 = new Book("Baba yaga3", 2006, "Petar");
            Book book4 = new Book("Baba yaga4", 2004, "Ivan");

            Library library = new Library(book4, book3, book2, book);

            library.SortBooks();

            foreach (var item in library)
            {
                Console.WriteLine(item);
            }
        }
    }
}
