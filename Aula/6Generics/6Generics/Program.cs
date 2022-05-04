using System;
using System.Collections.Generic;
using System.Globalization;
using _6Generics.Model.Entities;
using _6Generics.Model.Services;

namespace _6Generics
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> productList = new List<Product>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(",");
                productList.Add(new Product(s[0], double.Parse(s[1], CultureInfo.InvariantCulture)));
            }
            CalculationService calculationService = new CalculationService();
            Console.WriteLine("Most expensive:");
            Console.WriteLine(calculationService.Max(productList));
        }
    }
}