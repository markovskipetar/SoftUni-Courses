using System;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {
            this.data = new T[initialCapacity];
        }

        private int initialCapacity = 4;
        private T[] data;

        public int Count { get; private set; }

        public void Add(T element)
        {
            if (this.data.Length == this.Count)
            {
                Resize();
            }

            this.data[this.Count] = element;

            this.Count++;
        }

        public T Remove()
        {
            T item = this.data[this.Count - 1];

            this.Count--;

            return item;
        }

        private void Resize()
        {
            T[] newData = new T[this.Count * 2];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }
    }
}
