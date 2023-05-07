namespace Orders
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        private double TotalPrice { get; set; }

        public Product(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void CalculateTotalPrice()
        {
            this.TotalPrice = this.Price * this.Quantity;
        }

        public override string ToString()
        {
            return $"{this.Name} -> {this.TotalPrice:f2}";
        }
    }
}
