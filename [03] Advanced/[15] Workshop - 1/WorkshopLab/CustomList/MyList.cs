using System;

namespace CustomList
{
    public class MyList
    {
        public MyList(int capacity = 4)
        {
            this.initialCapacity = capacity;
            this.data = new int[capacity];
        }

        private int initialCapacity;
        private int[] data;
        public int Count { get; private set; }

        public int this[int index]
        {
            get => this.data[index];
            set => this.data[index] = value;
        }

        public void Add(int element)
        {
            CheckForResize();

            this.data[this.Count] = element;

            this.Count++;
        }

        public void Insert(int index, int element)
        {
            ValidateIndex(index);

            CheckForResize();

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + 1] = this.data[i];
            }

            this.data[index] = element;

            this.Count++;
        }

        public void InsertRange(int index, MyList elemets)
        {
            ValidateIndex(index);

            int resizesCount = GetResizesCount(elemets);

            for (int i = 0; i < resizesCount; i++)
            {
                Resize();
            }

            int shiftPositions = elemets.Count;

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.data[i + shiftPositions] = this.data[i];
            }

            int elementIndex = 0;

            for (int i = index; i < index + elemets.Count; i++)
            {
                this.data[i] = elemets[elementIndex++];
                this.Count++;
            }
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int removed = this.data[index];

            for (int i = index + 1; i < this.Count; i++)
            {
                this.data[i - 1] = this.data[i];
            }

            this.Count--;

            return removed;
        }

        public int Remove(Func<int, bool> predicate)
        {
            int removedCount = 0;

            for (int i = 0; i < this.Count; i++)
            {
                int currentNumber = this.data[i];

                if (predicate(currentNumber))
                {
                    this.RemoveAt(i);

                    removedCount++;
                    i--;
                }
            }

            return removedCount;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            int firstValue = this.data[firstIndex];

            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = firstValue;
        }

        public bool Containts(int element)
        {
            foreach (var number in this.data)
            {
                if (number == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Clear()
        {
            this.data = new int[initialCapacity];
            this.Count = 0;
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new Exception("Invalid index");
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
            int newCapacity = this.data.Length * 2;

            int[] newData = new int[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        private int GetResizesCount(MyList elemets)
        {
            int availableCapacity = this.data.Length - this.Count;

            int resizesCount = 0;

            while (true)
            {
                if (availableCapacity >= elemets.Count)
                {
                    break;
                }

                if (availableCapacity == 0)
                {
                    availableCapacity = this.data.Length;
                }
                else
                {
                    availableCapacity += this.data.Length;
                }

                resizesCount++;
            }

            return resizesCount;
        }

        public void Print()
        {
            for (int i = 0; i < this.Count; i++)
            {
                Console.WriteLine($"[{i}] {this.data[i]} ");
            }

            Console.WriteLine(this.data.Length);
        }
    }
}
