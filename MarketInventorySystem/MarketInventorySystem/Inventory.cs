using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketInventorySystem
{
    internal class Inventory
    {

        public static List<Product> productsList = new List<Product>();
        public void crop()

        {

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Show all of the product list");
                Console.WriteLine("3. Search product");
                Console.WriteLine("4. Remove");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Select Option");
                char option = Convert.ToChar(Console.ReadLine());

                switch (option)
                {
                    case '1':
                        Console.WriteLine("1- Fruit/Vegetable");
                        Console.WriteLine("2- Food");
                        Console.WriteLine("Select Sub Option");
                        char options = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("How many products will be added?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine("Add new product name");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Add product type");
                            string Category = Console.ReadLine();
                            Console.WriteLine("Add price");
                            decimal Price = Convert.ToDecimal(Console.ReadLine());

                            NonFoodProduct foods = new NonFoodProduct(Name, Category, Price);
                            productsList.Add(foods);
                            Console.WriteLine((i + 1) + ".product added");
                        }
                        break;

                    case '2':
                        foreach (var product in productsList)
                        {
                            Console.WriteLine("\nname: " + product.Name + "\ncategory: " + product.Category + "\nprice: " + product.Price);
                        }
                        break;

                    case '3':
                        Search("milk ", productsList);
                        return;
                        break;

                    case '4':
                        bool bo = true;
                        Console.WriteLine("Remove Now");
                        string removeProduct = Console.ReadLine();
                        foreach (var item in productsList)
                        {
                            if (item.Name == removeProduct)
                            {
                                productsList.Remove(item);
                                Console.WriteLine("Deleted");
                                bo = false;
                                break;
                            }
                        }
                        break;

                    case '5':

                        exit = false;
                        Console.WriteLine("Exit");

                        break;
                }
            }
        }
        public void ListProducts()
        {
            foreach (var product in productsList)
            {
                Console.WriteLine(product.Name + " " + product.Category + " " + product.Price);
            }
        }
        public void Search(string seach_name, List<Product> list)
        {
            foreach (var product in productsList)
            {
                if (seach_name == product.Name)
                {
                    Console.WriteLine("\nname: " + product.Name + "\ncategory: " + product.Category + "\nprice: " + product.Price);
                }

            }
        }
    }
}