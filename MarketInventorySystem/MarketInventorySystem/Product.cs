using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInventorySystem
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public Product(string name, string category, decimal price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
    public class NonFoodProduct : Product
    {
        public int Date { get; set; }
        public NonFoodProduct(string name, string category, decimal price) : base(name, category, price)
        {
        }
    }
    public class FoodProduct : Product
    {
        public int Date { get; set; }
        public FoodProduct(string name, string category, decimal price) : base(name, category, price)
        {
        }
    }
}
