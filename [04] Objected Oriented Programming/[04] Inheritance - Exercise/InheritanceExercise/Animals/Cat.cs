﻿namespace Animals
{
    internal class Cat : Animal
    {
        private const string CatSound = "Meow meow";

        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return CatSound;
        }
    }
}
