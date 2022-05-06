using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _6Generics.Model.Entities
{
    internal class Product : IComparable
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(Object obj)
        {
            if (obj is Product)
            {
                Product other = obj as Product;
                return Price.CompareTo(other.Price);
            }
            throw new ArgumentException("Comparing error: Argument is not a a Product.");
        }
    }
}