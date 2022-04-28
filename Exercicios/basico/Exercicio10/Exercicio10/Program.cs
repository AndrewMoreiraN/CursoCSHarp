using System;

namespace Exercicio10
{
    internal class Program
    {
        private static int Transforma_Para_Int(string numero)
        {
            return int.Parse(numero);
        }

        private static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas: ");
            int linhas = Transforma_Para_Int(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas: ");
            int colunas = Transforma_Para_Int(Console.ReadLine());

            int[,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < colunas; j++)
                {
                    int numero = Transforma_Para_Int(values[j]);
                    mat[i, j] = numero;
                }
            }
            int number = Transforma_Para_Int(Console.ReadLine());
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (number == mat[i, j])
                    {
                        Console.WriteLine($"Position {i},{j}");
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                    }
                }
            }
        }
    }
}