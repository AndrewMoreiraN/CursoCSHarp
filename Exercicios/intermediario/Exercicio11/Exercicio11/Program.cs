using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Model.Entities;

namespace Exercicio11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter file full path: " + @"G:\Cursos\CursoCSHarp\Exercicios\intermediario\Exercicio11\Exercicio11\InputFile\Input.txt");
            HashSet<Log> sorted = new HashSet<Log>();
            try
            {
                using (StreamReader sr = new StreamReader(@"G:\Cursos\CursoCSHarp\Exercicios\intermediario\Exercicio11\Exercicio11\InputFile\Input.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(" ");
                        sorted.Add(new Log(s[0], DateTime.Parse(s[1])));
                    }
                }
                Console.WriteLine($"Total users: {sorted.Count}");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}