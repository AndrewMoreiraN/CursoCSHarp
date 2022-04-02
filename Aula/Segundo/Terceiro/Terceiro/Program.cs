using System;
using System.Globalization;

namespace Terceiro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SegundoArray();
        }

        public static void PrimeiroArray()
        {
            Console.Write("Digite a quantidade de alturas: ");
            int numero = int.Parse(Console.ReadLine());
            float[] alturas = new float[numero];
            float media = 0.0f;
            for (int i = 0; i < alturas.Length; i++)
            {
                Console.Write($"Digite a altura {i + 1}: ");
                alturas[i] = float.Parse(Console.ReadLine());
            }
            foreach (float item in alturas)
            {
                media += item;
            }
            Console.WriteLine($"Altura média = {(media / numero).ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void SegundoArray()
        {
            Console.Write("Digite o número de produtos: ");
            int numero = int.Parse(Console.ReadLine());
            double precoMedio = 0.0;
            Produto[] arrayProduto = new Produto[numero];
            for (int i = 0; i < arrayProduto.Length; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                arrayProduto[i] = new Produto(nome, preco);
            }
            foreach (Produto item in arrayProduto)
            {
                precoMedio += item.Preco;
            }
            Console.WriteLine($"Valor médio de preços: {(precoMedio / numero).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}