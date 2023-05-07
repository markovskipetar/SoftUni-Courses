namespace Animals
{
    internal class Kitten : Cat
    {
        private const string KittenGender = "female";
        private const string KittenSound = "Meow";

        public Kitten(string name, int age)
            : base(name, age, KittenGender)
        {
        }

        public override string ProduceSound()
        {
            return KittenSound;
        }
    }
}
