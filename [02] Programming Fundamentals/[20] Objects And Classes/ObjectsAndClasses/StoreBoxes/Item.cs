﻿namespace StoreBoxes
{
    public class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }
}
