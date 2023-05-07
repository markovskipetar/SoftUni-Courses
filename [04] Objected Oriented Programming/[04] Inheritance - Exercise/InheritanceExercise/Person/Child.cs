namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            protected set
            {
                if (value < 15)
                {
                    base.Age = value;
                }
            }
        }

        public override string Name
        {
            get => base.Name;
            protected set
            {
                if (value == "petar")
                {
                    Console.WriteLine("child");

                    base.Name = value.ToUpper();
                }
                else
                {
                    base.Name = value;

                }
            }
        }
    }
}
