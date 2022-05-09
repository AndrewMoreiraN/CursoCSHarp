using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Model.Entities;
using Model.Services;

namespace Exercicio1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"G:\Cursos\CursoCSHarp\Exercicios\avancado\Exercicio1\Exercicio1\Input\Input.csv";
            List<Product> products = new List<Product>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    products.Add(new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture)));
                }
            }
            double averagePrice = ProductService.AveragePrice(products);
            Console.WriteLine("Enter full file path: " + path);
            Console.WriteLine("Average price: " + averagePrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("List of products with price lower than average:");
            Print(ProductService.NameOfProductsWithPriceLowerThanAverage(products, averagePrice));
        }

        private static void Print(IEnumerable<string> list)
        {
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}