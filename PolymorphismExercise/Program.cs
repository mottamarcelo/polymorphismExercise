﻿using PolymorphismExercise.Entities;

namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if(type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));
                }
                else if(type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}