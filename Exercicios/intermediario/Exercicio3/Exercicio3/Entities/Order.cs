using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Exercicio3.Entities.Enums;

namespace Exercicio3.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            double totalPrice = 0;
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine($"Order items:");

            foreach (OrderItem item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, " +
                            $"${item.Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                            $"Quantity: {item.Quantity}, " +
                            $"Subtotal: {item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                totalPrice += item.SubTotal();
            }
            sb.AppendLine($"Total price: ${totalPrice.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}