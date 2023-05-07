namespace GenericBox
{
    public class CustomLinkedList<T>
    {
        public CustomLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        Node<T> head;
        Node<T> tail;

        public int Count { get; private set; }

        public void Add(T item)
        {
            Node<T> node = new Node<T>(item);

            if (this.Count == 0)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                node.Next = null;
                node.Prveious = this.tail;

                this.tail.Next = node;
                this.tail = node;
            }

            this.Count++;
        }

        public T Remove()
        {
            T value = this.tail.Value;

            if (this.Count == 1)
            {
                this.tail = null;
                this.head = null;
            }
            else
            {
                this.tail = this.tail.Prveious;
                this.tail.Next = null;
            }

            this.Count--;

            return value;
        }
    }
}
