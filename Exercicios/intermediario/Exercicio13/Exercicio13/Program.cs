using System;
using System.Collections.Generic;
using System.IO;

namespace Exercicio13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = @"G:\Cursos\CursoCSHarp\Exercicios\intermediario\Exercicio13\Exercicio13\Input\Input.csv";
            try
            {
                Dictionary<string, int> numberVoted = new Dictionary<string, int>();
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] s = sr.ReadLine().Split(",");
                        if (numberVoted.ContainsKey(s[0]))
                        {
                            numberVoted[s[0]] += int.Parse(s[1]);
                        }
                        else
                        {
                            numberVoted[s[0]] = int.Parse(s[1]);
                        }
                    }
                }
                foreach (KeyValuePair<string, int> item in numberVoted)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}