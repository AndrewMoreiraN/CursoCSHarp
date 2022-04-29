using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualRevenue { get; set; }

        public TaxPayer()
        {
        }

        protected TaxPayer(string name, double anualRevenue)
        {
            Name = name;
            AnualRevenue = anualRevenue;
        }

        public abstract double Tax();
    }
}