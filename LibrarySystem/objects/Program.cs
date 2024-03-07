using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();
            books.Add(new { name = "Physics", autor = "Newton", janr = "Science" });
            books.Add(new { name = "Math", autor = "Pifagor", janr = "Science" });
            books.Add(new { name = "Astronomy", autor = "Albert Einstein", janr = "Science" });
            books.Add(new { name = "History", autor = "Herodotus", janr = "Science" });

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1-book add");
                Console.WriteLine("2-book list show");
                Console.WriteLine("3-book delete");
                Console.WriteLine("4-book search");
                Console.WriteLine("5-Update");
                Console.WriteLine("6- exit");

                Console.WriteLine("select option");
                char operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {
                    case '1':
                        Console.WriteLine("How many books do you want to add?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Add a book name: ");
                            string bookName = Console.ReadLine();
                            Console.Write("Add a book autor: ");
                            string bookAutor = Console.ReadLine();
                            Console.Write("Add a book janr: ");
                            string janr = Console.ReadLine();
                            object book = new { name = bookName, autor = bookAutor, janr = janr };
                            books.Add(book);
                            Console.WriteLine((i + 1) + ".book added");
                        }
                        break;

                    case '2':
                        foreach (dynamic item in books)
                        {
                            Console.WriteLine("name:" + item.name + "\n autor:" + item.autor + "\n janr: " + item.janr + "\n");
                        }
                        break;

                    case '3':
                        bool find = false;
                        Console.WriteLine("please, enter book name");
                        string name = Console.ReadLine();
                        foreach (dynamic item in books)
                        {
                            if (item.name == name)
                            {
                                books.Remove(item);
                                find = true;
                                Console.WriteLine("Delete Book.");
                                break;
                            }
                        }
                        if (!find)
                        {
                            Console.WriteLine("Not found");
                        }
                        break;

                    case '4':
                        bool found = false;
                        Console.WriteLine("Search Book");
                        string search_name = Console.ReadLine();
                        foreach (dynamic item in books)
                        {
                            if (search_name == item.ad)
                            {
                                found = true;
                                Console.WriteLine("name:" + item.name + "\n autor:" + item.autor + "\n janr: " + item.janr + "\n");
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("not found");
                        }
                        break;

                    case '5':
                        bool boolFound = false;
                        Console.WriteLine("Which book do you want update");
                        string searchName = Console.ReadLine();
                        foreach (dynamic item in books)
                        {
                            if (item.ad == searchName)
                            {
                                Console.WriteLine("Please enter new name");
                                string newName = Console.ReadLine();
                                item.ad = newName;
                                Console.WriteLine("new name" + item.ad);
                                boolFound = true;
                                break;
                            }
                        }
                        if (!boolFound)
                        {
                            Console.WriteLine("not found");
                        }
                        break;

                    case '6':
                        exit = false;
                        Console.WriteLine("Exited");
                        break;
                }
            }
        }
    }
}