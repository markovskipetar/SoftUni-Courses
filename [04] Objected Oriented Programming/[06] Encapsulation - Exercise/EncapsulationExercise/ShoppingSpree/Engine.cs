
namespace ShoppingSpree
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Engine
    {
        public void Run()
        {
            string[] peopleAndMoney = ReadData();
            var people = new Dictionary<string, Person>();

            try
            {
                for (int i = 0; i < peopleAndMoney.Length; i++)
                {
                    string[] arguments = peopleAndMoney[i].Split('=').ToArray();
                    string name = arguments[0];
                    decimal money = decimal.Parse(arguments[1]);

                    Person person = new Person(name, money);

                    people[name] = person;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string[] productsAndPrices = ReadData();
            var products = new Dictionary<string, Product>();

            try
            {
                for (int i = 0; i < productsAndPrices.Length; i++)
                {
                    string[] arguments = productsAndPrices[i].Split('=').ToArray();

                    string name = arguments[0];
                    decimal price = decimal.Parse(arguments[1]);

                    Product product = new Product(name, price);

                    products[name] = product;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            while (true)
            {
                string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                string personName = input[0];
                string productName = input[1];

                Person person = people[personName];
                Product product = products[productName];

                bool isProductBought = person.BuyProduct(product);

                string message = "";

                if (isProductBought)
                {
                    message = $"{personName} bought {productName}";
                }
                else
                {
                    message = $"{personName} can't afford {productName}";
                }

                Console.WriteLine(message);
            }

            foreach (var person in people)
            {
                Console.WriteLine(person.Value);
            }
        }

        private string[] ReadData()
        {
            string[] data = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return data;
        }
    }
}
