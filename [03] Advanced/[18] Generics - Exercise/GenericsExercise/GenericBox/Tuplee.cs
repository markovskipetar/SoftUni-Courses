namespace GenericBox
{
    public class Tuplee<TFirst, TSeconds>
    {
        public Tuplee(TFirst firstItem, TSeconds secondItem)
        {
            this.FirstItem= firstItem;
            this.Secondtem = secondItem;
        }

        public TFirst FirstItem { get; private set; }
        public TSeconds Secondtem { get; private set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.Secondtem}";
        }
    }
}
