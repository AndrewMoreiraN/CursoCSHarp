using System;
using System.Globalization;

namespace Exercicio5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 5:");
            Retangulo ret = new Retangulo((Console.ReadLine()), (Console.ReadLine()));
            Console.WriteLine(ret);
        }
    }
}