namespace PizzaCalories
{
    using System;
    using System.Linq;

    public class Engine
    {
        public Engine()
        {
            this.pizza = null;
        }

        private Pizza pizza;

        public void Start()
        {
            try
            {
                while (true)
                {
                    string[] input = Console.ReadLine().Split().ToArray();

                    string product = input[0];

                    if (product == "END")
                    {
                        Console.WriteLine(pizza);

                        break;
                    }

                    if (product == "Pizza")
                    {
                        string pizzaName = input[1];

                        this.pizza = new Pizza(pizzaName);
                    }
                    else if (product == "Dough")
                    {
                        string flourType = input[1];
                        string bakingTechnique = input[2];
                        int weight = int.Parse(input[3]);

                        Dough dough = new Dough(flourType, bakingTechnique, weight);

                        this.pizza.AddDough(dough);
                    }
                    else if (product == "Topping")
                    {
                        string toppingType = input[1];
                        int weight = int.Parse(input[2]);

                        Topping topping = new Topping(toppingType, weight);

                        this.pizza.AddTopping(topping);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
