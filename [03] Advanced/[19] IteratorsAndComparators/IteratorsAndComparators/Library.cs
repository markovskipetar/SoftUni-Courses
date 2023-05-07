using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library()
        {
            this.books = new List<Book>();
        }

        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        private List<Book> books;

        public void SortBooks()
        {
            this.books.Sort(new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new BookEnumerator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
