namespace GenericBox
{
    using System;
    using System.Collections.Generic;

    public static class Box<T>
        where T : IComparable
    {
        public static int Count(List<T> elements, T elementToCompare)
        {
            int count = 0;

            foreach (var element in elements)
            {
                if (elementToCompare.CompareTo(element) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
