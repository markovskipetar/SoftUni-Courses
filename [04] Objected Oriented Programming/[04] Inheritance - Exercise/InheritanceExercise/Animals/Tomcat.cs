namespace Animals
{
    internal class Tomcat : Cat
    {
        private const string TomcatGender = "male";
        private const string TomcatSound = "MEOW";

        public Tomcat(string name, int age)
            : base(name, age, TomcatGender)
        {
        }

        public override string ProduceSound()
        {
            return TomcatSound;
        }
    }
}
