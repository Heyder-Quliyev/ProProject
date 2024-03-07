using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodProduct product1 = new FoodProduct("milk", "dairies", 3);
            FoodProduct product2 = new FoodProduct("potato", "vegetable", 2);
            FoodProduct product3 = new FoodProduct("butter", "dairies", 14);
            FoodProduct product4 = new FoodProduct("Beef", "meat products", 20);

            Inventory.productsList.Add(product1);
            Inventory.productsList.Add(product2);
            Inventory.productsList.Add(product3);
            Inventory.productsList.Add(product4);
            Inventory menu = new Inventory();
            menu.crop();

            string sname = Console.ReadLine();
            menu.Search(sname, Inventory.productsList);
        }
    }
}
//there're 175 codes in total