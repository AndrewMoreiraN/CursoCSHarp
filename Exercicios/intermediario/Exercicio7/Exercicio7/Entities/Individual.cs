using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio7.Entities
{
    internal class Individual : TaxPayer
    {
        public double MedicalExpenses { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualRevenue, double medicalExpenses) : base(name, anualRevenue)
        {
            MedicalExpenses = medicalExpenses;
        }

        public override double Tax()
        {
            return AnualRevenue > 20000 ? (AnualRevenue * 0.25) - 0.5 * MedicalExpenses : (AnualRevenue * 0.15) - 0.5 * MedicalExpenses;
        }
    }
}