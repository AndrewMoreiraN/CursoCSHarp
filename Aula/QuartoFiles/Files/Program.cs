using QuartoFiles;
using System;
using System.IO;
using System.Reflection;

namespace Files
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = CurrentDirectory + @"\file1.txt";
            string targetPath = CurrentDirectory + @"\file2.txt";
            //FillStream_StreamReader.Exec(path, targetPath);
            //Using_Block.Exec(path);
            //Stream_Writer.Exec(path, targetPath);
            Directory_DirectoryInfo.Exec(CurrentDirectory);
        }
    }
}