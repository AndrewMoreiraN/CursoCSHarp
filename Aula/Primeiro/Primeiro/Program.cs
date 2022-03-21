using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool complete = false;
            byte n1 = 126;
            char genero = 'F';
            char letra = '\u0041';
            decimal n10 = decimal.MaxValue;
            decimal n9 = decimal.MinValue;
            double n6 = 4.515123;
            float n5 = 4.518312f;
            int n2 = 1000;
            int n3 = 2147483647;
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            long n4 = 2147483648L;
            Object obj1 = "Andrew Moreira";
            Object obj2 = 4.5;
            string nome = "Andrew";
            //definir numero de casas decimais
            //Console.WriteLine(n6.ToString("F3"));
            //colocar . ao invés de ,
            //Console.WriteLine(n5.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(n9);
            //Console.WriteLine(n10);
            //Console.WriteLine(ExercioDeFixacao());
        }

        private static String ExercioDeFixacao()
        {
            string resultado = "";

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            resultado = $"Produtos:\n{produto1}, cujo preço é $ {preco1.ToString("F2")}\n{produto2}, cujo preço é ${preco2.ToString("F2")}\n\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n\nMedida com oito casas decimais: {medida.ToString("F8")}\nArredondado (três casas decimais): {medida.ToString("F3")}\nSeparador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}";

            return resultado;
        }
    }
}