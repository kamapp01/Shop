using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class Item : Order
    {
        public string ID { get; set; }
        public string itemDescription { get; set; }
        public double price { get; set; }

        
        public Item(string id, string description, double price)
        {
            ID = id;
            itemDescription = description;
            this.price = price;
        }

        
        public override double Cost()
        {
            return price;
        }

        
        public override string Description()
        {
            return $"{itemDescription}";
        }

        
        public override string ToString()
        {
            return $"Item ID: {ID.PadRight(5)}, Description: {itemDescription.PadRight(20)}, Price: {price.ToString().PadLeft(6)} kr";
        }
    }
}
