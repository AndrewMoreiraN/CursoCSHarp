using System;
using System.Linq;
using System.Collections.Generic;
using Model.Entities;

namespace Linq
{
    internal class Program
    {
        private static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            // LinqTest.Teste();

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){ Id = 1, Name="Computer", Price = 1100.0, Category = c2},
                new Product(){ Id = 2, Name="Hammer", Price = 90.0, Category = c1},
                new Product(){ Id = 3, Name="TV", Price = 1700.0, Category = c3},
                new Product(){ Id = 4, Name="Notebook", Price = 1300.0, Category = c2},
                new Product(){ Id = 5, Name="Saw", Price = 80.0, Category = c1},
                new Product(){ Id = 6, Name="Tablet", Price = 700.0, Category = c2},
                new Product(){ Id = 7, Name="Camera", Price = 700.0, Category = c3},
                new Product(){ Id = 8, Name="Printer", Price = 350.0, Category = c3},
                new Product(){ Id = 9, Name="MacBook", Price = 1800.0, Category = c2},
                new Product(){ Id = 10, Name="Sound Bar", Price = 700.0, Category = c3},
                new Product(){ Id = 11, Name="Level", Price = 70.0, Category = c1},
            };

            Console.WriteLine("TIER 1 AND PRICE < 900");

            IEnumerable<Product> r1 = products
                .Where(x => x.Category.Tier == 1 && x.Price < 900);
            IEnumerable<string> r2 = products
                .Where(x => x.Category.Name == "Tools")
                .Select(x => x.Name);
            var r3 = products
                .Where(x => x.Name[0] == 'c' || x.Name[0] == 'C')
                .Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            IEnumerable<Product> r4 = products
                .Where(x => x.Category.Tier == 1)
                .OrderBy(x => x.Price)
                .ThenBy(x => x.Name);
            var r5 = r4
                .Skip(2)
                .Take(4);

            var r6 = products.FirstOrDefault();
            var r7 = products.Where(x => x.Price > 3000.0).FirstOrDefault();

            var r8 = products.Where(x => x.Id == 3).SingleOrDefault();
            var r9 = products.Where(x => x.Id == 30).SingleOrDefault();

            var r10 = products.Max(x => x.Price);
            var r11 = products.Min(x => x.Price);
            var r12 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            var r13 = products.Where(x => x.Category.Id == 1).Average(x => x.Price);
            var r14 = products.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty(0.0).Average();
            var r15 = products.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate(0.0, (x, y) => x + y);
            var r16 = products.GroupBy(x => x.Category);

            Print("Tier 1 And Price < 900", r1);
            Print("Names of products from tools", r2);
            Print("Products that the name starts with 'C'", r3);
            Print("Products tier 1 OrderBy Price ThenBy Name", r4);
            Print("Products tier 1 OrderBy Price ThenBy Name (SKIP 2, TAKE 4)", r5);
            Console.WriteLine("First or default test1: " + r6);
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine("Single or default test1: " + r8);
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine("Max product price: " + r10);
            Console.WriteLine("Min product price: " + r11);
            Console.WriteLine("Sum of prices from products category id 1: " + r12);
            Console.WriteLine("Average of prices from products category id 1: " + r13);
            Console.WriteLine("Average of prices from products category id 5: " + r14);
            Console.WriteLine("Aggregate sum: " + r15);
            Console.WriteLine();
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine($"Category {group.Key.Name}:");
                foreach (Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }
        }
    }
}