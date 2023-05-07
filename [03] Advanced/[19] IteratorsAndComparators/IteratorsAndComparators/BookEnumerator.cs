namespace IteratorsAndComparators
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    internal class BookEnumerator : IEnumerator<Book>
    {
        public BookEnumerator(List<Book> books)
        {
            this.books = books;

            Reset();
        }

        private List<Book> books;
        private int index;

        public Book Current => this.books[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {       
        }

        public bool MoveNext()
        {
            this.index++;

            return this.index < this.books.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
