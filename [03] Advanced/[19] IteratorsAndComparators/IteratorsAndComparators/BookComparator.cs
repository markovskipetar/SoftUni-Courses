using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book first, Book second)
        {
            int result = first.Year.CompareTo(second.Year);

            if (result == 0)
            {
                result = second.Title.CompareTo(first.Title);
            }

            return result;
        }
    }
}
