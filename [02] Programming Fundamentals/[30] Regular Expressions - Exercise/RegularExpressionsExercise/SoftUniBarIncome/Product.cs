namespace SoftUniBarIncome
{
    public class Product
    {
        public Product(string name, double totalPrice)
        {
            this.Name = name;
            this.TotalPrice = totalPrice;
        }

        public string Name { get; private set; }
        public double TotalPrice { get; private set; }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalPrice:F2}";
        }
    }
}
