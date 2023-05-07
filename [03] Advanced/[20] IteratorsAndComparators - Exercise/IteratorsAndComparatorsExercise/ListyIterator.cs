namespace IteratorsAndComparatorsExercise
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ListyIterator<T> : IEnumerable<T>
    {
        public ListyIterator()
        {
            this.data = new List<T>();
        }

        private List<T> data;
        private int index = 0;

        public void AddData(List<T> data)
        {
            this.data = data;
        }

        public bool Move()
        {
            if (this.index >= this.data.Count - 1)
            {
                return false;
            }

            index++;
            return true;
        }

        public bool HasNext()
        {
            return index < this.data.Count - 1;
        }

        public void Print()
        {
            if (this.data.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(this.data[index]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
