using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuartoFiles
{
    internal class Using_Block

    {
        public static void Exec(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}