using System;

namespace CustomList
{
    internal class MyStack
    {
        public MyStack(int capacity = 4)
        {
            this.data = new int[capacity];
            this.initialCapacity = capacity;
        }

        private int[] data;
        private int initialCapacity;
        public int Count { get; private set; }

        public void Push(int element)
        {
            CheckForResize();

            this.data[this.Count] = element;

            this.Count++;
        }

        public int Peek()
        {
            CheckIfStackIsEmpty();

            int elemetToPeek = this.data[this.Count - 1];

            return elemetToPeek;
        }

        public void Clear()
        {
            this.Count = 0;

            this.data = new int[initialCapacity];
        }

        public int Pop()
        {
            CheckIfStackIsEmpty();

            int elemetToPop = this.data[this.Count - 1];

            this.Count--;

            return elemetToPop;
        }

        private void CheckIfStackIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new Exception("Stack is empty");
            }
        }

        private void CheckForResize()
        {
            if (this.Count == this.data.Length)
            {
                Resize();
            }
        }

        private void Resize()
        {
            int newSize = this.data.Length * 2;

            int[] newData = new int[newSize];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        public void Print()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.data[i]);
            }
        }
    }
}
