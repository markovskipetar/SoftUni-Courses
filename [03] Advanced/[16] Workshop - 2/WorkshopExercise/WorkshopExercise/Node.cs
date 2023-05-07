namespace WorkshopExercise
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }

        public int Value { get; private set; }
        public Node PreviousNode { get; set; }
        public Node NextNode { get; set; }
    }
}
