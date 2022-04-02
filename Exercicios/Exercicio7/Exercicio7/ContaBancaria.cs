using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio7
{
    internal class ContaBancaria
    {
        public ContaBancaria(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

        public ContaBancaria(int numeroConta, string titularConta, double saldo) : this(numeroConta, titularConta)
        {
            Saldo = saldo;
        }

        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public string TitularConta { get; set; }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {TitularConta}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}