using System;
using System.Collections;
using System.Collections.Generic;

namespace WorkshopExercise
{
    public class DoublyLinkedList : IEnumerable<int>
    {
        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public void AddFirst(int element)
        {
            if (this.Count == 0)
            {
                Node node = new Node(element);

                this.head = node;
                this.tail = node;
            }
            else
            {
                Node oldNode = this.head;
                Node newNode = new Node(element);

                this.head = newNode;

                newNode.NextNode = oldNode;
                newNode.PreviousNode = null;

                oldNode.PreviousNode = newNode;
            }

            this.Count++;
        }

        public void AddLast(int element)
        {
            if (this.Count == 0)
            {
                SetHeadAndTailToNull();
            }
            else
            {
                Node oldNode = this.tail;
                Node newNode = new Node(element);

                this.tail = newNode;

                newNode.NextNode = null;
                newNode.PreviousNode = oldNode;

                oldNode.NextNode = newNode;
            }

            this.Count++;
        }

        public int RemoveFirst()
        {
            CheckIfEmpty();

            int elementToReturn = this.head.Value;

            if (this.Count == 1)
            {
                SetHeadAndTailToNull();
            }
            else
            {
                Node newHead = this.head.NextNode;
                newHead.PreviousNode = null;

                this.head = newHead;
            }

            this.Count--;

            return elementToReturn;
        }

        public int RemoveLast()
        {
            CheckIfEmpty();

            int elementToReturn = this.tail.Value;

            if (this.Count == 1)
            {
                SetHeadAndTailToNull();
            }
            else
            {
                Node newTail = this.tail.PreviousNode;
                newTail.NextNode = null;

                this.tail = newTail;
            }

            this.Count--;

            return elementToReturn;
        }

        public void ForEach(Action<int> action)
        {
            Node currentNode = this.head;

            while (true)
            {
                if (currentNode is null)
                {
                    break;
                }

                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int index = 0;

            Node currentNode = this.head;

            while (true)
            {
                if (currentNode is null)
                {
                    break;
                }

                array[index++] = currentNode.Value;

                currentNode = currentNode.NextNode;
            }

            return array;
        }

        private void CheckIfEmpty()
        {
            if (this.Count == 0)
            {
                throw new Exception("List is empty!");
            }
        }

        private void SetHeadAndTailToNull()
        {
            this.head = null;
            this.tail = null;
        }

        public IEnumerator<int> GetEnumerator()
        {
            Node node = this.head;

            while (true)
            {
                if (node is null)
                {
                    break;
                }

                yield return node.Value;

                node = node.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
