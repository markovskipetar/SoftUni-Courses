namespace StoreBoxes
{
    public class Box
    {
        public Box(string serialNumber, Item item, double itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public double ItemQuantity { get; set; }
        public double PriceForBox { get; set; }

        public void CalculatePriceForBox()
        {
            double itemPrice = this.Item.Price;

            double priceForBox = this.ItemQuantity * itemPrice;

            this.PriceForBox = priceForBox;
        }
    }
}
