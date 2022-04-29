using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualRevenue, int numberOfEmployees) : base(name, anualRevenue)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            return NumberOfEmployees > 10 ? 0.14 * AnualRevenue : 0.16 * AnualRevenue;
        }
    }
}