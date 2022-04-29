using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio5.Entities;

namespace Exercicio5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());
            List<Product> productList = new List<Product>();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeOfProduct = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (typeOfProduct == 'c')
                {
                    productList.Add(new Product(name, price));
                }
                else if (typeOfProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    productList.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in productList)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}