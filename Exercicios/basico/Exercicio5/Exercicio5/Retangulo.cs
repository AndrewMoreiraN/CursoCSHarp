using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio5
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public Retangulo(string altura, string largura)
        {
            Largura = double.Parse(largura, CultureInfo.InvariantCulture);
            Altura = double.Parse(altura, CultureInfo.InvariantCulture);
        }

        private string Area()
        {
            return (Largura * Altura).ToString("F2", CultureInfo.InvariantCulture);
        }

        private string Perimetro()
        {
            return (Largura * 2 + Altura * 2).ToString("F2", CultureInfo.InvariantCulture);
        }

        private string Diagonal()
        {
            return (Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2))).ToString("F2", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"\tAREA = {Area()}\n" +
                $"\tPERIMETRO = {Perimetro()}\n" +
                $"\tDIAGONAL = {Diagonal()}";
        }
    }
}