using System;

namespace Exercicio3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercício 1:");
            Exercicio1();
            Console.WriteLine("\nExercício 2:");
            Exercicio2();
            Console.WriteLine("\nExercício 3:");
            Exercicio3();
        }

        private static void Exercicio1()
        {
            string senha = "2002";
            while (true)
            {
                if (Console.ReadLine() == "2002")
                    break;
                else
                    Console.WriteLine("\tSenha Invalida");
            }
            Console.WriteLine("\tAcesso Permitido");
        }

        private static void Exercicio2()
        {
            while (true)
            {
                string[] s = Console.ReadLine().Split(" ");
                if (s[0] == "0" || s[1] == "0")
                    break;
                else
                {
                    int n0 = int.Parse(s[0]);
                    int n1 = int.Parse(s[1]);
                    if (n0 > 0 && n1 > 0)
                        Console.WriteLine("\tprimeiro");
                    else if (n0 > 0 && n1 < 0)
                        Console.WriteLine("\tquarto");
                    else if (n0 < 0 && n1 > 0)
                        Console.WriteLine("\tsegundo");
                    else
                        Console.WriteLine("\tterceiro");
                }
            }
        }

        private static void Exercicio3()
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (true)
            {
                string codigo = Console.ReadLine();
                if (codigo == "1")
                {
                    alcool++;
                }
                else if (codigo == "2")
                {
                    gasolina++;
                }
                else if (codigo == "3")
                {
                    diesel++;
                }
                else if (codigo == "4")
                {
                    break;
                }
            }
            Console.WriteLine("\tMUITO OBRIGADO");
            Console.WriteLine($"\tAlcool: {alcool}");
            Console.WriteLine($"\tGasolina: {gasolina}");
            Console.WriteLine($"\tDiesel: {diesel}");
        }
    }
}