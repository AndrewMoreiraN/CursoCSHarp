using System;
using System.Collections.Generic;
using System.Text;
using TerceiroEnum.Entities.Enums;

namespace TerceiroEnum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}