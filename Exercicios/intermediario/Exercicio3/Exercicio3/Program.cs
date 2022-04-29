using System;
using System.Globalization;
using Exercicio3.Entities;
using Exercicio3.Entities.Enums;

namespace Exercicio3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());

            Client c1 = new Client(clientName, clientEmail, clientBirthDate);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order o1 = new Order(DateTime.Now, orderStatus, c1);
            Console.Write("How many items to this order? ");
            int numberOfItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());
                o1.AddItem(new OrderItem(productQuantity, productPrice, new Product(productName, productPrice)));
            }

            Console.WriteLine();
            Console.WriteLine(o1);
        }
    }
}