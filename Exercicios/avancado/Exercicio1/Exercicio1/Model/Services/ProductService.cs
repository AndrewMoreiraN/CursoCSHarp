using System;
using System.Collections.Generic;
using System.Text;
using Model.Entities;
using System.Linq;

namespace Model.Services
{
    internal class ProductService
    {
        public static double AveragePrice(List<Product> products)
        {
            var averagePrice = products
                .Select(x => x.Price)
                .DefaultIfEmpty(0.0)
                .Average();
            return averagePrice;
        }

        public static IEnumerable<string> NameOfProductsWithPriceLowerThanAverage(List<Product> products, double averagePrice)
        {
            var listOfProducts = products
                .Where(x => x.Price < averagePrice)
                .OrderByDescending(x => x.Name)
                .Select(x => x.Name);
            return listOfProducts;
        }
    }
}