using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities.Enums
{
    internal enum OrderStatus
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}