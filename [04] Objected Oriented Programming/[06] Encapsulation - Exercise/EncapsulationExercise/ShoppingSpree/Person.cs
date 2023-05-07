namespace ShoppingSpree
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        private string name;
        private decimal money;
        private List<Product> products;

        public string Name
        {
            get => this.name;

            private set
            {
                Validator.ValidateName(value);

                this.name = value;
            }
        }

        public decimal Money
        {
            get => this.money;

            private set
            {
                Validator.ValidateMoney(value);

                this.money = value;
            }
        }

        public bool BuyProduct(Product product)
        {
            if (product.Price > this.money)
            {
                return false;
            }

            this.products.Add(product);
            this.money -= product.Price;

            return true;
        }

        public override string ToString()
        {
            string productsInfo = $"{this.name} - {string.Join(", ", products)}";

            if (this.products.Count == 0)
            {
                productsInfo = $"{this.name} - Nothing bought";
            }

            return productsInfo;
        }
    }
}
