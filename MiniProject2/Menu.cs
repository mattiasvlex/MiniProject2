﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject2
{
    internal class Menu
    {
        public static string GetCommand()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("To enter a new product - press 'p' | To search for a product - press 's' | To quit - press 'q'");
            Console.ResetColor();
            string? command = Console.ReadLine();
            return command ?? "";
        }
        public static string GetCategory()
        {
            Console.Write("Enter product category: ");
            string? category = Console.ReadLine();
            return category ?? "";
        }
        public static string GetName()
        {
            Console.Write("Enter product name: ");
            string? name = Console.ReadLine();
            return name ?? "";
        }
        public static string GetPrice()
        {
            Console.Write("Enter price: ");
            string? price = Console.ReadLine();
            return price ?? "";
        }
        public static void PrintError(string error)
        {
            Console.WriteLine("Invalid input: " + error);
        }
        public static void PrintAdded()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("The product was successfully added!");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------");
        }
        public static void Quit(List<Product> list, int total)
        {
            PrintCategories();
            foreach (Product product in list)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine("\n" + "Total amount:".PadLeft(38) + "            " + total);
            Console.WriteLine("--------------------------------------------------------");
        }
        public static void PrintSearch(List<Product> products, List<Product> found)
        {
            PrintCategories();

            if (found.Count != 0)  //If something matched the search
            {
                foreach (var p in products)
                {
                    foreach (var f in found)
                    {
                        if (p == f)  //Print the search result
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(p);
                            Console.ResetColor();
                        }
                        else //All other items in list
                        {
                            Console.WriteLine(p);
                        }
                    }
                }
            } else  //If nothing matched the search
            {
                foreach (var p in products)
                {
                    Console.WriteLine(p);
                }
            }
            Console.WriteLine("--------------------------------------------------------");
        }
        private static void PrintCategories()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Category".PadRight(25) + "Product".PadRight(25) + "Price");
            Console.ResetColor();
        }
    }
}
