namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main()
        {
            Animal animal = new Animal("viktor");
            Reptile animal2 = new Reptile("ivan");
            Mammal animal3 = new Mammal("pesho");
            Lizard animal4 = new Lizard("sasho");

            Console.WriteLine(animal);
            Console.WriteLine(animal2);
            Console.WriteLine(animal3);
            Console.WriteLine(animal4);
        }
    }
}