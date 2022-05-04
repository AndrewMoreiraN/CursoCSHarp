using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace QuintoInterfaces.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; private set; }
        public double Tax { get; private set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\nTax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\nTotalPayment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}