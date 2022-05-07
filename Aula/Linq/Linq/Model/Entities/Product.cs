using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Model.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, double price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name}, {Id}, {Price.ToString("F2", CultureInfo.InvariantCulture)}, {Category.Name}, {Category.Tier}";
        }
    }
}