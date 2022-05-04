using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10.Services
{
    internal interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);
    }
}