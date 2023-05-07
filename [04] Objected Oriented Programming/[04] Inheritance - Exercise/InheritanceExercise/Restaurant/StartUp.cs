namespace Restaurant
{
    public class StartUp
    {
        public static void Main()
        {
            Food food = new Food("torta",10,45);
            Console.WriteLine(food.Grams);
        }
    }
}