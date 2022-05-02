using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuartoFiles
{
    internal class Directory_DirectoryInfo
    {
        public static void Exec(string path)
        {
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}