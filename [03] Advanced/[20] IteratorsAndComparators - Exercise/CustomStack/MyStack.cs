namespace CustomStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class MyStack<T> : IEnumerable<T>
    {
        public MyStack()
        {
            this.data = new T[capacity];
        }

        private T[] data;
        private int capacity = 4;

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count == this.data.Length)
            {
                Resize();
            }

            this.data[this.Count] = element;
            this.Count++;
        }

        public void Pop()
        {
            if (this.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.Count--;
            }
        }

        private void Resize()
        {
            int newCapacity = this.data.Length * 2;

            T[] newData = new T[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
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
